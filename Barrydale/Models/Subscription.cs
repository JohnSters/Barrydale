using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barrydale.Models
{
    public class Subscription
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int BusinessId { get; set; }
        
        [ForeignKey("BusinessId")]
        public Business? Business { get; set; }
        
        [Required]
        [StringLength(50)]
        public string PlanType { get; set; } = "Basic"; // Basic, Premium, Enterprise
        
        [Required]
        public decimal Amount { get; set; }
        
        [Required]
        public DateTime StartDate { get; set; } = DateTime.UtcNow;
        
        [Required]
        public DateTime EndDate { get; set; }
        
        public bool IsActive { get; set; } = true;
        
        [StringLength(50)]
        public string? PaymentProvider { get; set; } // PayFast, etc.
        
        [StringLength(100)]
        public string? PaymentReference { get; set; }
        
        [StringLength(50)]
        public string? SubscriptionStatus { get; set; } // Active, Canceled, Expired, etc.
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        
        public bool AutoRenew { get; set; } = true;
        
        [StringLength(255)]
        public string? CancellationReason { get; set; }
    }
} 