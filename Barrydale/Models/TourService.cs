using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barrydale.Models
{
    [Table("Businesses")]
    public class TourService : Business
    {
        public TourService()
        {
            BusinessType = "TourService";
        }
        
        [StringLength(50)]
        public string? TourType { get; set; } // Walking, Driving, Adventure, etc.
        
        public int? DurationHours { get; set; } // Duration in hours
        
        public int? MaxGroupSize { get; set; }
        
        public decimal? PricePerPerson { get; set; }
        
        public bool PrivateToursAvailable { get; set; }
        
        [StringLength(500)]
        public string? Highlights { get; set; } // Key highlights of the tour
        
        [StringLength(500)]
        public string? IncludedItems { get; set; } // What's included in the tour
        
        [StringLength(200)]
        public string? MeetingPoint { get; set; }
        
        public bool RequiresBooking { get; set; } = true;
    }
} 