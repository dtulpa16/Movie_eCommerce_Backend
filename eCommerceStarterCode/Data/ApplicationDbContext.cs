using eCommerceStarterCode.Configuration;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;



namespace ApplicationDbContext.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<User> IdentityUser { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<Product> Products { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .HasData(
                new Product { Id = 1, Name = "Oklahoma", Description = "xxx", Price = '2', Type = "Musical" },
                new Product { Id = 2, Name = "Happy Gilmore", Description = "xxx", Price = '3', Type = "Comedy" },
                new Product { Id = 3, Name = "Love: After Lockup", Description = "xxx", Price = '5', Type = "Documentary" },
                new Product { Id = 4, Name = "SNatch", Description = "xxx", Price = '6', Type = "Comedy" },
                new Product { Id = 5, Name = "The Parent Trap", Description = "xxx", Price = '2', Type = "Musical" }



          );

        }
    }
}

