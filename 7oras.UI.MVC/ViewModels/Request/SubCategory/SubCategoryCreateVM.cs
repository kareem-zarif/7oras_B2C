using System.ComponentModel.DataAnnotations;

namespace _7oras.UI.MVC.ViewModels.Request.SubCategory
{
    public class SubCategoryCreateVM
    {

        [Required, MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
        //nav
        public Guid CategoryId { get; set; }
    }
}
