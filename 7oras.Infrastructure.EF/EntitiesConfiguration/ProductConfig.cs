using _7oras.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _7oras.Infrastructure.EF.EntitiesConfiguration
{
        public class ProductConfig : IEntityTypeConfiguration<Product>
        {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Description).IsRequired(true).HasMaxLength(500);
            builder.Property(x => x.PricePerPiece).IsRequired(true);
            builder.Property(x => x.NoINStock).IsRequired(true);
            builder.Property(x => x.MinNumToFactoryOrder).IsRequired(true);
            builder.Property(x => x.ProductPicsPathes).IsRequired(false);

            builder.HasData(
                new Product 
                {
                Id = Guid.NewGuid(),
                Name = "Sample Product",
                Description = "This is a sample product description.",
                PricePerPiece = 10.99,
                PricePer50Piece = 9.99,
                PricePer100Piece = 8.99,
                NoINStock = 100,
                MinNumToFactoryOrder = 10,
                SubCategoryId = Guid.NewGuid(), 
                SupplierId = Guid.NewGuid() 
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Sample Product 2",
                    Description = "This is another sample product description.",
                    PricePerPiece = 10.99,
                    PricePer50Piece = 9.99,
                    PricePer100Piece = 8.99,
                    NoINStock = 100,
                    MinNumToFactoryOrder = 10,
                    SubCategoryId = Guid.NewGuid(),
                    SupplierId = Guid.NewGuid()
                }
            );
        }
    }
}
