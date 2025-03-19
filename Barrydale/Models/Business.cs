using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Barrydale.Data;

namespace Barrydale.Models
{
    public class Business
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;
        
        [StringLength(200)]
        public string Address { get; set; } = string.Empty;
        
        [StringLength(20)]
        public string Phone { get; set; } = string.Empty;
        
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        
        [StringLength(255)]
        [Url]
        public string? Website { get; set; }
        
        public decimal Latitude { get; set; }
        
        public decimal Longitude { get; set; }
        
        [StringLength(50)]
        public string Category { get; set; } = string.Empty;
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        
        public bool IsActive { get; set; } = true;
        
        public bool IsFeatured { get; set; } = false;
        
        // Navigation properties
        [Required]
        public string OwnerId { get; set; } = string.Empty;
        
        [ForeignKey("OwnerId")]
        public ApplicationUser? Owner { get; set; }
        
        public ICollection<BusinessImage> Images { get; set; } = new List<BusinessImage>();
        
        public ICollection<BusinessHours> BusinessHours { get; set; } = new List<BusinessHours>();
        
        public Subscription? Subscription { get; set; }
    }
} 