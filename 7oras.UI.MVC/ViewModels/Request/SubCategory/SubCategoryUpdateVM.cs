using System.ComponentModel.DataAnnotations;

namespace _7oras.UI.MVC.ViewModels.Request.SubCategory
{
    public class SubCategoryUpdateVM
    {
        [Required]
        public Guid Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
    }
}
