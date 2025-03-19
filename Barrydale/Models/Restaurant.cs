using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barrydale.Models
{
    [Table("Businesses")]
    public class Restaurant : Business
    {
        public Restaurant()
        {
            BusinessType = "Restaurant";
        }
        
        [StringLength(100)]
        public string? Cuisine { get; set; }
        
        public bool AcceptsReservations { get; set; }
        
        [Range(1, 4)]
        public int? PriceRange { get; set; } // 1-4 for $-$$$$
        
        public bool ServesAlcohol { get; set; }
        
        [StringLength(500)]
        public string? SpecialDiets { get; set; } // Vegetarian, Vegan, Gluten-free, etc.
        
        [StringLength(100)]
        public string? MealTypes { get; set; } // Breakfast, Lunch, Dinner
    }
} 