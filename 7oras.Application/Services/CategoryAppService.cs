using _7oras.Domain.Interfaces.IRepos;

namespace _7oras.Application.Services
{
    public class CategoryAppServic : BaseAppService<Category, CategoryAppCreateDto, CategoryAppUpdateDto, CategoryAppResDto>, ICategoryAppService
    {
        public CategoryAppServic(IUOW uow, IMapper mapper) : base(uow, mapper)
        {
        }
        protected override ICategoryRepo _baseRepo => _uow.CategoryRepo;

    }
}
