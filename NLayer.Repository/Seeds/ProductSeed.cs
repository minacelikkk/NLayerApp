using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Keçeli Kalem",
                    Price = 100,
                    Stock = 20,
                    CreateDate = DateTime.Now
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Kurşun Kalem",
                    Price = 120,
                    Stock = 10,
                    CreateDate = DateTime.Now
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Name = "Tükenmez Kalem",
                    Price = 300,
                    Stock = 200,
                    CreateDate = DateTime.Now
                },
                 new Product
                 {
                     Id = 4,
                     CategoryId = 2,
                     Name = "Ders Kitabı",
                     Price = 50,
                     Stock = 60,
                     CreateDate = DateTime.Now
                 },
                 new Product
                 {
                     Id = 5,
                     CategoryId = 2,
                     Name = "Çalışma Kitabı",
                     Price = 500,
                     Stock = 60,
                     CreateDate = DateTime.Now
                 });
        }
    }
}
