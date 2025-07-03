namespace _7oras.Application.Services
{
    public class CategoryAppServic : BaseAppService<Category, CategoryAppCreateDto, CategoryAppUpdateDto, CategoryAppResDto>, ICategoryAppService
    {
        public CategoryAppServic(IUOW uow, IMapper mapper) : base(uow, mapper)
        {
        }
        protected override IBaseRepo<Category> _baseRepo => _uow.CategoryRepo;

    }
}
