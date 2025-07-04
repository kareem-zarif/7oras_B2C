using _7oras.Application.Shared.Dtos.Request.SubCategory;
using _7oras.Application.Shared.Dtos.Response.SubCategory;

namespace _7oras.Application.Validators
{
    public class SubCategoryAppService : BaseAppService<SubCategory, SubCategoryAppCreateDto, SubCategoryAppUpdateDto, SubCategoryAppResDto>, ISubCategoryAppService
    {
        public SubCategoryAppService(
            IUOW uow,
            IMapper mapper,
            IValidator<SubCategoryAppCreateDto> createValidator,
            IValidator<SubCategoryAppUpdateDto> updateValidator
            ) : base(uow, mapper, createValidator, updateValidator)
        {
        }

        protected override IBaseRepo<SubCategory> _baseRepo => throw new NotImplementedException();
    }
}
