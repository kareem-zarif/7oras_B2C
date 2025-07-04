using _7oras.UI.MVC.ViewModels.Response.SubCategory;

namespace _7oras.UI.MVC.ViewModels.Response.Category
{
    public class CategoryResVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        //nav
        public IList<SubCategoryResVM> SubCategories { get; set; }
    }
}
