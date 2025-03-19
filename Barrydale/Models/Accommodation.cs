using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barrydale.Models
{
    [Table("Businesses")]
    public class Accommodation : Business
    {
        public Accommodation()
        {
            BusinessType = "Accommodation";
        }
        
        public int NumberOfRooms { get; set; }
        
        public int MaxGuests { get; set; }
        
        public bool HasWifi { get; set; }
        
        public bool HasParking { get; set; }
        
        public bool HasPool { get; set; }
        
        public bool IsEntireProperty { get; set; }
        
        [StringLength(500)]
        public string? Amenities { get; set; } // Comma-separated list of amenities
        
        [StringLength(50)]
        public string? AccommodationType { get; set; } // Hotel, Guest House, Self-catering, etc.
        
        [StringLength(200)]
        public string? CheckInInstructions { get; set; }
        
        public decimal BasePricePerNight { get; set; }
    }
} 