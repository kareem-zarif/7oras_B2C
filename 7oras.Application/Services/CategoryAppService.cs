using _7oras.Domain.Interfaces.IRepos;

namespace _7oras.Application.Validators
{
    public class CategoryAppServic : BaseAppService<Category, CategoryAppCreateDto, CategoryAppUpdateDto, CategoryAppResDto>, ICategoryAppService
    {
        public CategoryAppServic(
            IUOW uow,
            IMapper mapper,
            IValidator<CategoryAppCreateDto> createValidator,
            IValidator<CategoryAppUpdateDto> updateValidator
            ) : base(uow, mapper, createValidator, updateValidator)
        {
        }
        protected override ICategoryRepo _baseRepo => _uow.CategoryRepo;

    }
}
