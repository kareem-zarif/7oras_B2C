using _7oras.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _7oras.Infrastructure.EF.EntitiesConfiguration
{
    public class SubCategoryConfig : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Description).IsRequired(false).HasMaxLength(500);

            builder.HasData(
                new SubCategory
                {
                    Id = Guid.NewGuid(),
                    Name = "Electronics",
                    Description = "Devices and gadgets",
                    CategoryId = Guid.NewGuid() 
                },
                new SubCategory
                {
                    Id = Guid.NewGuid(),
                    Name = "Books",
                    Description = "Various genres of books",
                    CategoryId = Guid.NewGuid() 
                }
            );
        }
    }
}
