using _7oras.Application.Shared.Dtos.Request.Category;
using _7oras.Application.Shared.Dtos.Request.SubCategory;
using _7oras.Application.Shared.Dtos.Response.Category;
using _7oras.Application.Shared.Dtos.Response.SubCategory;
using _7oras.UI.MVC.ViewModels.Request.SubCategory;
using _7oras.UI.MVC.ViewModels.Response.Category;
using _7oras.UI.MVC.ViewModels.Response.SubCategory;

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

            CreateMap<CategoryUpdateVM, CategoryAppResDto>().ReverseMap(); //For Edit [Get]
            #endregion

            #region Category
            CreateMap<SubCategoryCreateVM, SubCategoryAppCreateDto>().ReverseMap();
            CreateMap<SubCategoryUpdateVM, SubCategoryAppUpdateDto>().ReverseMap();
            CreateMap<SubCategoryResVM, SubCategoryAppResDto>().ReverseMap();

            #endregion
        }
    }
}
