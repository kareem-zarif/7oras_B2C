namespace _7oras.Application.AutoMapper
{
    public class MappingAppProfile : Profile
    {
        public MappingAppProfile()
        {
            //CreateMap<source,Destination>();

            #region Category
            CreateMap<CategoryAppCreateDto, Category>();
            CreateMap<CategoryAppUpdateDto, Category>();
            CreateMap<CategoryAppResDto, Category>();
            #endregion
        }
    }
}
