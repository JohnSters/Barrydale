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
        public DbSet<BusinessImage> BusinessImages { get; set; }
        public DbSet<BusinessHours> BusinessHours { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configure relationships and constraints
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

            // Fix decimal precision warnings
            builder.Entity<Business>()
                .Property(b => b.Latitude)
                .HasPrecision(18, 9);

            builder.Entity<Business>()
                .Property(b => b.Longitude)
                .HasPrecision(18, 9);

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

            // Add more configurations as needed
        }
    }
}
