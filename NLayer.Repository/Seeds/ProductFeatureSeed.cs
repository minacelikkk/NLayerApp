using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Seeds
{
    internal class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(new ProductFeature
            {
                Id = 1,
                Color = "Siyah",
                Height = 100,
                Width = 200,
                ProductId = 1

            },
            new ProductFeature
            {
                Id = 2,
                Color = "Gri",
                Height = 80,
                Width = 150,
                ProductId = 2

            });
        }
    }
}
