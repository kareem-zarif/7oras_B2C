namespace _7oras.Application.Shared.Dtos.Response.SubCategory
{
    public class SubCategoryAppResDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public Guid CategoryId { get; set; }
        //nav products
        //public virtual CategoryAppResDto CatRespDto { get; set; }
    }
}
