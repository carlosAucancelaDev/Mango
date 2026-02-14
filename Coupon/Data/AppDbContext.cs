using Mango.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.CouponAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Cuopon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cuopon>().HasData(new Cuopon
            {
                CuoponId = 1,
                CuoponCode = "ab22",
                DiscountAmount = 23,
                MinAmount = 12
            });
            modelBuilder.Entity<Cuopon>().HasData(new Cuopon
            {
                CuoponId = 2,
                CuoponCode = "gfdg22",
                DiscountAmount = 233,
                MinAmount = 44
            });
        }
    }
}
