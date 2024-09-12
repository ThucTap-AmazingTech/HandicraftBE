using Handicraft.Contract.Repositories.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handicraft.Repositories.DatabaseContext
{
    public class DatabaseContext : IdentityDbContext<User>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<DiscountEvent> Discounts { get; set; }
        public DbSet<DiscountEventsProduct> DiscountsEventsProducts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Product> Products { get; set; }
        public override DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Call base OnModelCreating
            base.OnModelCreating(modelBuilder);
        

            modelBuilder.Entity<Product>()
                    .Property(o => o.Price)
                    .HasConversion<decimal>();
    
            modelBuilder.Entity<Product>()
                    .Property(o => o.Discount)
                    .HasConversion<decimal>();
        }

    }
}
