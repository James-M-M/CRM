using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CRM.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectAttachment> ProjectAttachments { get; set; }
        public DbSet<Device> Devices { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Customer>()
                .HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserID)
                .OnDelete(DeleteBehavior.SetNull);
            builder.Entity<Staff>()
                .HasOne(s => s.User)
                .WithMany()
                .HasForeignKey(s => s.UserID)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Project>()
                .HasOne(p => p.Customer)
                .WithMany(c => c.Projects)
                .HasForeignKey(p => p.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Project>()
                .HasMany(p => p.AssignedStaff);
           // builder.Entity<Staff>().HasMany(s => s.Devices);
        }
    }
}
