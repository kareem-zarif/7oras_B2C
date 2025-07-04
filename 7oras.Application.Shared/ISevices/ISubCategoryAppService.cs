using _7oras.Application.Shared.Dtos.Request.SubCategory;
using _7oras.Application.Shared.Dtos.Response.SubCategory;

namespace _7oras.Application.Shared.ISevices
{
    public interface ISubCategoryAppService : IBaseAppService<SubCategoryAppCreateDto, SubCategoryAppUpdateDto, SubCategoryAppResDto>
    {
    }
}
