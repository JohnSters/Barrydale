using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Barrydale.Data;

namespace Barrydale.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;
        
        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;
        
        [Required]
        public DateTime StartDate { get; set; }
        
        public DateTime? EndDate { get; set; }
        
        [StringLength(200)]
        public string Location { get; set; } = string.Empty;
        
        public decimal? Latitude { get; set; }
        
        public decimal? Longitude { get; set; }
        
        [StringLength(100)]
        public string? OrganizedBy { get; set; }
        
        [StringLength(255)]
        public string? ImageUrl { get; set; }
        
        [StringLength(255)]
        [Url]
        public string? TicketUrl { get; set; }
        
        public decimal? TicketPrice { get; set; }
        
        public bool IsFeatured { get; set; } = false;
        
        public bool IsActive { get; set; } = true;
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        
        // Navigation properties
        public string? CreatedById { get; set; }
        
        [ForeignKey("CreatedById")]
        public ApplicationUser? CreatedBy { get; set; }
        
        public int? BusinessId { get; set; }
        
        [ForeignKey("BusinessId")]
        public Business? Business { get; set; }
    }
} 