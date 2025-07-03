using _7oras.Application.Shared.Dtos.Request.Category;
using _7oras.Application.Shared.Dtos.Response.Category;

namespace _7oras.Application.Shared.ISevices
{
    public interface ICategoryAppService : IBaseAppService<CategoryAppCreateDto, CategoryAppUpdateDto, CategoryAppResDto>
    {
    }
}
