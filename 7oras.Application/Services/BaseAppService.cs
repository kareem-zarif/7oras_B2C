namespace _7oras.Application.Services
{
    public abstract class BaseAppService<TEntity, TAppCreateDto, TAppUpdateDto, TAppResDto>
        : IBaseAppService<TAppCreateDto, TAppUpdateDto, TAppResDto>
        where TEntity : BaseEnt
        where TAppCreateDto : class
        where TAppUpdateDto : class
        where TAppResDto : class
    {
        protected readonly IUOW _uow;
        protected readonly IMapper _mapper;
        #region Why abstract IBaseRepo Property 
        //-abstract to foerce any devired class to tell me which repo
        //can not inject both _unitOfWork and _baseRepo as i will have 2 instances of repo (one by UOW and other by BaseRepo) 
        //can not inject _baseRepo instead of  _unitOfWork as i lose transictional Complete  =>ex: student and StudentCourse must change when student leave coursw
        //It property with {get;} not attribute with readonly as readonly attribute as conventioal used in constructor depencey injection which  

        #endregion
        protected abstract IBaseRepo<TEntity> _baseRepo { get; }
        protected BaseAppService(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public virtual async Task<TAppResDto> GetAsync(Guid id)
        {
            var found = await _baseRepo.GetAsync(id);
            var mapped = _mapper.Map<TAppResDto>(found);
            return mapped;
        }

        public virtual async Task<IList<TAppResDto>> GetAllAsync()
        {
            var foundList = await _baseRepo.GetAllAsync();
            var mappedList = _mapper.Map<IList<TAppResDto>>(foundList);
            return mappedList;
        }

        public virtual async Task<TAppResDto> CreateAsync(TAppCreateDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            var created = await _baseRepo.CreateAsync(entity);
            int saved = await _uow.Complete();
            if (saved > 0)
            {
                var mapped = _mapper.Map<TAppResDto>(created);
                return mapped;
            }
            else throw new Exception("error occured when saving changes in DB");
        }

        public virtual async Task<TAppResDto> UpdateAsync(TAppUpdateDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            var updated = await _baseRepo.UpdateAsync(entity);
            int saved = await _uow.Complete();
            if (saved > 0)
            {
                var mapped = _mapper.Map<TAppResDto>(updated);
                return mapped;
            }
            else throw new Exception("error occured when saving changes in DB");
        }

        public virtual async Task<TAppResDto> DeleteAsync(Guid id)
        {
            var deleted = await _baseRepo.DeleteAsync(id);
            int saved = await _uow.Complete();
            if (saved > 0)
                return _mapper.Map<TAppResDto>(deleted);
            else throw new Exception("error occured when saving changes in DB");
        }

        //Eager Loading
        public async Task<TAppResDto> GetAsyncInclude(Guid id)
        {
            var found = await _baseRepo.GetAsyncInclude(id);
            var mapped = _mapper.Map<TAppResDto>(found);
            return mapped;
        }

        public async Task<IList<TAppResDto>> GetAllAsyncInclude()
        {
            var foundList = await _baseRepo.GetAllAsyncInclude();
            var mappedList = _mapper.Map<IList<TAppResDto>>(foundList);
            return mappedList;
        }

        public async Task<TAppResDto> CreateAsyncInclude(TAppCreateDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            var created = await _baseRepo.CreateAsyncInclude(entity);
            int saved = await _uow.Complete();
            if (saved > 0)
            {
                var mapped = _mapper.Map<TAppResDto>(created);
                return mapped;
            }
            else throw new Exception("error occured when saving changes in DB");
        }

        public async Task<TAppResDto> UpdateAsyncInclude(TAppUpdateDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            var updated = await _baseRepo.UpdateAsyncInclude(entity);
            int saved = await _uow.Complete();
            if (saved > 0)
            {
                var mapped = _mapper.Map<TAppResDto>(updated);
                return mapped;
            }
            else throw new Exception("error occured when saving changes in DB");
        }

        public async Task<TAppResDto> DeleteAsyncInclude(Guid id)
        {
            var deleted = await _baseRepo.DeleteAsyncInclude(id);
            int saved = await _uow.Complete();
            if (saved > 0)
            {
                var mapped = _mapper.Map<TAppResDto>(deleted);
                return mapped;
            }
            else throw new Exception("error occured when saving changes in DB");
        }


    }
}
