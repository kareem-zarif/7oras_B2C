using _7oras.Application.Shared.Dtos.Request.Category;
using _7oras.Application.Shared.Dtos.Response.Category;
using _7oras.UI.MVC.ViewModels.Response.Category;

namespace _7oras.UI.MVC.AutoMapper
{
    public class MappingMVCProfile : Profile
    {
        public MappingMVCProfile()
        {
            #region Category
            CreateMap<CategoryCreateVM, CategoryAppCreateDto>().ReverseMap();
            CreateMap<CategoryUpdateVM, CategoryAppUpdateDto>().ReverseMap();
            CreateMap<CategoryResVM, CategoryAppResDto>().ReverseMap();
            #endregion
        }
    }
}
