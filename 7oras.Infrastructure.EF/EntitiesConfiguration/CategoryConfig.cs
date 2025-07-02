using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _7oras.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _7oras.Infrastructure.EF.EntitiesConfiguration
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Description).HasMaxLength(500);
           
            builder.HasData(
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Electronics",
                    Description = "Devices and gadgets"
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Books",
                    Description = "Various genres of literature"
                }
            );
        }
    }
}
