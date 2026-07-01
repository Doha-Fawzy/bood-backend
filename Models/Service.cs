using System.ComponentModel.DataAnnotations;

namespace Bood.Api.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public ServiceCategory Category { get; set; }

        public string? ImageUrl { get; set; }
    }
}
