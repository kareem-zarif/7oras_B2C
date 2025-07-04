namespace _7oras.Application.Shared.Dtos.Request.SubCategory
{
    public class SubCategoryAppCreateDto
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public Guid CategoryId { get; set; }
    }
}
