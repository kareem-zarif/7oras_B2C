namespace _7oras.UI.MVC.ViewModels.Response.SubCategory
{
    public class SubCategoryResVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public Guid CategoryId { get; set; }
        //nav
        //public virtual CategoryAppResDto CatRespDto { get; set; }
    }
}
