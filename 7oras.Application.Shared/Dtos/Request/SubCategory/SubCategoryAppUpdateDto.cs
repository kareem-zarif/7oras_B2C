using System.ComponentModel.DataAnnotations;

namespace _7oras.Application.Shared.Dtos.Request.SubCategory
{
    public class SubCategoryAppUpdateDto
    {
        [Required]
        public Guid Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
    }
}
