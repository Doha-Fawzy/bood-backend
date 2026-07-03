using System.ComponentModel.DataAnnotations;

namespace Bood.Api.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string TitleEn { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string TitleAr { get; set; } = string.Empty;

        [Required]
        public string DescriptionEn { get; set; } = string.Empty;

        [Required]
        public string DescriptionAr { get; set; } = string.Empty;

        [Required]
        public ServiceCategory Category { get; set; }

        public string? ImageUrl { get; set; }
    }
}
