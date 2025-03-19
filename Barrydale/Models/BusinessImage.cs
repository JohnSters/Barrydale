using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barrydale.Models
{
    public class BusinessImage
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int BusinessId { get; set; }
        
        [ForeignKey("BusinessId")]
        public Business? Business { get; set; }
        
        [Required]
        [StringLength(255)]
        public string ImageUrl { get; set; } = string.Empty;
        
        [StringLength(100)]
        public string? Caption { get; set; }
        
        public bool IsPrimary { get; set; } = false;
        
        public int DisplayOrder { get; set; } = 0;
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
} 