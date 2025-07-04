using _7oras.Application.Shared.Dtos.Request.SubCategory;
using _7oras.Application.Shared.Dtos.Response.SubCategory;

namespace _7oras.Application.AutoMapper
{
    public class MappingAppProfile : Profile
    {
        public MappingAppProfile()
        {
            //CreateMap<source,Destination>().reversMap();

            #region Category
            CreateMap<CategoryAppCreateDto, Category>().ReverseMap();
            CreateMap<CategoryAppUpdateDto, Category>().ReverseMap();
            CreateMap<CategoryAppResDto, Category>().ReverseMap();
            #endregion

            #region SubCategory
            CreateMap<SubCategoryAppCreateDto, SubCategory>().ReverseMap();
            CreateMap<SubCategoryAppUpdateDto, SubCategory>().ReverseMap();
            CreateMap<SubCategoryAppResDto, SubCategory>().ReverseMap();
            #endregion
        }
    }
}
