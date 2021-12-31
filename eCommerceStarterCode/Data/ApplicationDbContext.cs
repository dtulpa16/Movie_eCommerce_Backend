using eCommerceStarterCode.Configuration;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;




namespace eCommerceStarterCode.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Reviews> Reviews { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RolesConfiguration());
            modelBuilder.Entity<ShoppingCart>()
                .HasKey(i => new { i.UserId, i.ProductId });



            modelBuilder.Entity<Genres>().HasData
            (
                new Genres
                {
                    Id = 1,
                    Type= "Musical"
                },
                new Genres
                {
                    Id = 2,
                    Type = "Comedy"
                },
                new Genres
                {
                    Id = 3,
                    Type = "Documentary"
                }
            );
            modelBuilder.Entity<Product>().HasData
            (
                
                new Product { Id = 1, Name = "Oklahoma", Description = "xxx", Price = '2', GenresId = 1},
                new Product { Id = 2, Name = "Happy Gilmore", Description = "xxx", Price = '3', GenresId = 2 },
                new Product { Id = 3, Name = "Love: After Lockup", Description = "xxx", Price = '5', GenresId = 3 },
                new Product { Id = 4, Name = "Snatch", Description = "xxx", Price = '6', GenresId = 1 },
                new Product { Id = 5, Name = "The Parent Trap", Description = "xxx", Price = '2', GenresId = 3 }

            );
        }







    }
}


