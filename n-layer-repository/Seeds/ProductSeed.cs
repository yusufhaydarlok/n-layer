using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using n_layer_core.Models;

namespace n_layer_repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
            new Product { Id = 1, CategoryId = 1, Name = "Kalem 1", Price = 100, Stock = 50, CreatedDate = DateTime.Now },
            new Product { Id = 2, CategoryId = 1, Name = "Kalem 2", Price = 150, Stock = 50, CreatedDate = DateTime.Now },
            new Product { Id = 3, CategoryId = 1, Name = "Kalem 3", Price = 300, Stock = 50, CreatedDate = DateTime.Now },
            new Product { Id = 4, CategoryId = 2, Name = "Kitap 1", Price = 25, Stock = 60, CreatedDate = DateTime.Now },
            new Product { Id = 5, CategoryId = 2, Name = "Kitap 2", Price = 50, Stock = 60, CreatedDate = DateTime.Now },
            new Product { Id = 6, CategoryId = 2, Name = "Kitap 3", Price = 75, Stock = 60, CreatedDate = DateTime.Now },
            new Product { Id = 7, CategoryId = 3, Name = "Defter 1", Price = 15, Stock = 90, CreatedDate = DateTime.Now },
            new Product { Id = 8, CategoryId = 3, Name = "Defter 2", Price = 25, Stock = 90, CreatedDate = DateTime.Now },
            new Product { Id = 9, CategoryId = 3, Name = "Defter 3", Price = 25, Stock = 90, CreatedDate = DateTime.Now }
            );
        }
    }
}
