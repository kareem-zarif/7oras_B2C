using _7oras.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _7oras.Infrastructure.EF.EntitiesConfiguration
{
    public class SupplierConfig : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Description).IsRequired(false).HasMaxLength(500);
            
            builder.HasData(
                new Supplier
                {
                    Id = Guid.NewGuid(),
                    Name = "Supplier A",
                    Description = "Description for Supplier A",
                    IFactoryPicPath = "path/to/picA.jpg"
                },
                new Supplier
                {
                    Id = Guid.NewGuid(),
                    Name = "Supplier B",
                    Description = "Description for Supplier B",
                    IFactoryPicPath = "path/to/picB.jpg"
                }
            );

        }
    }
}
