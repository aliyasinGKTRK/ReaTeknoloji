using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ReaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; database=ReaDb;Trusted_Connection=false");
        }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                    modelBuilder.Entity<Category>()
              .HasData(
                  new Category() { Id = 1, Name = "Klavye" },
                  new Category() { Id = 2, Name = "Monitör" },
                  new Category() { Id = 3, Name = "Mouse" }
                      );


            modelBuilder.Entity<Product>()
                .HasData(
                    new Product() { Id = 1, CategoryId = 1, ProductName = "Rampage", Description = "Oyuncu klavyesi", Price = 500 },
                    new Product() { Id = 2, CategoryId = 1, ProductName = "Micropack", Description = "RGB Oyuncu klavyesi", Price = 250 },
                    new Product() { Id = 3, CategoryId = 1, ProductName = "Everest", Description = "Beyaz kablosuz Q klavye", Price = 200 },
                    new Product() { Id = 4, CategoryId = 1, ProductName = "logitech", Description = "Kablosuz Q klavye", Price = 150 },
                    new Product() { Id = 5, CategoryId = 2, ProductName = "Huawei", Description = "IPS Ekran Monitör", Price = 6000 },
                    new Product() { Id = 6, CategoryId = 2, ProductName = "Samsung", Description = "Curved oyuncu monitörü", Price = 6000 },
                    new Product() { Id = 7, CategoryId = 2, ProductName = "Samsung", Description = "IPS Ekran monitör", Price = 5000 },
                    new Product() { Id = 8, CategoryId = 2, ProductName = "LG", Description = "IPS Ekran monitör", Price = 5000 },
                    new Product() { Id = 9, CategoryId = 2, ProductName = "LG", Description = "Cruved monitör", Price = 4500 },
                    new Product() { Id = 10, CategoryId = 3, ProductName = "logitech", Description = "Kablosuz mouse", Price = 500 },
                    new Product() { Id = 11, CategoryId = 3, ProductName = "Everest", Description = "Kablosuz mouse", Price = 500 },
                    new Product() { Id = 12, CategoryId = 3, ProductName = "Rampage", Description = "Kablosuz oyunucu mouse", Price = 1500 },
                    new Product() { Id = 13, CategoryId = 3, ProductName = "Rampage", Description = "Kablosuz oyunucu mouse", Price = 1500 }

                );
            
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
