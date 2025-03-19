using Barrydale.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Barrydale.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Business> Businesses { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Accommodation> Accommodations { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<TourService> TourServices { get; set; }
        public DbSet<Attraction> Attractions { get; set; }
        public DbSet<BusinessImage> BusinessImages { get; set; }
        public DbSet<BusinessHours> BusinessHours { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configure TPH inheritance
            builder.Entity<Business>()
                .HasDiscriminator<string>("BusinessType")
                .HasValue<Business>("Generic")
                .HasValue<Restaurant>("Restaurant")
                .HasValue<Accommodation>("Accommodation")
                .HasValue<Shop>("Shop")
                .HasValue<TourService>("TourService")
                .HasValue<Attraction>("Attraction");
                
            // Configure decimal precision
            builder.Entity<Business>()
                .Property(b => b.Latitude)
                .HasPrecision(18, 9);

            builder.Entity<Business>()
                .Property(b => b.Longitude)
                .HasPrecision(18, 9);

            builder.Entity<Accommodation>()
                .Property(a => a.BasePricePerNight)
                .HasPrecision(10, 2);

            builder.Entity<TourService>()
                .Property(t => t.PricePerPerson)
                .HasPrecision(10, 2);

            builder.Entity<Attraction>()
                .Property(a => a.AdmissionFee)
                .HasPrecision(10, 2);

            // Configure relationships
            builder.Entity<Business>()
                .HasOne(b => b.Owner)
                .WithMany(u => u.OwnedBusinesses)
                .HasForeignKey(b => b.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Subscription>()
                .HasOne(s => s.Business)
                .WithOne(b => b.Subscription)
                .HasForeignKey<Subscription>(s => s.BusinessId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Review>()
                .HasOne(r => r.Business)
                .WithMany()
                .HasForeignKey(r => r.BusinessId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Review>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Event>()
                .Property(e => e.Latitude)
                .HasPrecision(18, 9);

            builder.Entity<Event>()
                .Property(e => e.Longitude)
                .HasPrecision(18, 9);

            builder.Entity<Event>()
                .Property(e => e.TicketPrice)
                .HasPrecision(10, 2);

            builder.Entity<Subscription>()
                .Property(s => s.Amount)
                .HasPrecision(10, 2);
        }
    }
}
