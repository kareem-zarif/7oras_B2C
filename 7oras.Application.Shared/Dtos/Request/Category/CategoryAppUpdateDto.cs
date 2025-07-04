using _7oras.Application.Shared.Dtos.Response.SubCategory;

namespace _7oras.Application.Shared.Dtos.Request.Category
{
    public class CategoryAppUpdateDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        //nav 
        public IList<SubCategoryAppResDto> SubCategories { get; set; }
    }
}
