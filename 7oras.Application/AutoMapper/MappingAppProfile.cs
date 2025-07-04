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
        }
    }
}
