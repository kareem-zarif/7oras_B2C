using _7oras.Application.Shared.Dtos.Response.SubCategory;

namespace _7oras.Application.Shared.Dtos.Response.Category
{
    public class CategoryAppResDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public IList<SubCategoryAppResDto> SubCategories { get; set; }
    }
}
