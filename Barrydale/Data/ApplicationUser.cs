using Barrydale.Models;
using Microsoft.AspNetCore.Identity;

namespace Barrydale.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        
        public string? LastName { get; set; }
        
        public string? ProfileImageUrl { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        public DateTime? LastLogin { get; set; }
        
        public bool IsBusinessOwner { get; set; } = false;
        
        public bool AcceptTerms { get; set; } = false;
        
        // Navigation properties
        public ICollection<Business>? OwnedBusinesses { get; set; }
        
        public ICollection<Review>? Reviews { get; set; }
    }
}
