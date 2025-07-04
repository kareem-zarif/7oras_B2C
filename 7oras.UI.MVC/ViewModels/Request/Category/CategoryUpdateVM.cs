using System.ComponentModel.DataAnnotations;

namespace _7oras.UI.MVC.ViewModels.Request.Category
{
    public class CategoryUpdateVM
    {
        [Required]
        public Guid Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(1000)]
        public string? Description { get; set; }
    }
}
