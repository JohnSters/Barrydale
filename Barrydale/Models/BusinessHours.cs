using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barrydale.Models
{
    public class BusinessHours
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int BusinessId { get; set; }
        
        [ForeignKey("BusinessId")]
        public Business? Business { get; set; }
        
        [Required]
        public DayOfWeek DayOfWeek { get; set; }
        
        public TimeSpan? OpenTime { get; set; }
        
        public TimeSpan? CloseTime { get; set; }
        
        public bool IsClosed { get; set; } = false;
        
        [StringLength(100)]
        public string? Note { get; set; }
    }
} 