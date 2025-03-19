using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barrydale.Models
{
    [Table("Businesses")]
    public class Shop : Business
    {
        public Shop()
        {
            BusinessType = "Shop";
        }
        
        [StringLength(50)]
        public string? ShopType { get; set; } // Retail, Grocery, Souvenir, etc.
        
        [StringLength(500)]
        public string? ProductTypes { get; set; } // What kind of products they sell
        
        public bool OffersDelivery { get; set; }
        
        public bool HasOnlineStore { get; set; }
        
        [StringLength(255)]
        [Url]
        public string? OnlineStoreUrl { get; set; }
        
        public bool AcceptsCreditCards { get; set; }
        
        [StringLength(200)]
        public string? Brands { get; set; } // Notable brands they carry
    }
} 