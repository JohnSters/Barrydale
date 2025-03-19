using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barrydale.Models
{
    [Table("Businesses")]
    public class Attraction : Business
    {
        public Attraction()
        {
            BusinessType = "Attraction";
        }
        
        [StringLength(50)]
        public string? AttractionType { get; set; } // Museum, Historical Site, Nature, etc.
        
        public decimal? AdmissionFee { get; set; }
        
        public bool HasGuidedTours { get; set; }
        
        [StringLength(200)]
        public string? BestTimeToVisit { get; set; }
        
        public int? RecommendedDurationMinutes { get; set; }
        
        [StringLength(500)]
        public string? Facilities { get; set; } // Bathrooms, Gift Shop, Cafe, etc.
        
        public bool FamilyFriendly { get; set; }
        
        public bool AccessibleForDisabled { get; set; }
        
        public bool OutdoorAttraction { get; set; }
    }
} 