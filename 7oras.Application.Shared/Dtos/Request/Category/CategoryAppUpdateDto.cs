using System.ComponentModel.DataAnnotations;

namespace _7oras.Application.Shared.Dtos.Request.Category
{
    public class CategoryAppUpdateDto
    {
        [Required]
        public Guid Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(1000)]
        public string? Description { get; set; }
    }
}
