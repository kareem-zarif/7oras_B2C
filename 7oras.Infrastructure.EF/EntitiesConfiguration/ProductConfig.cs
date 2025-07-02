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
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Description).IsRequired().HasMaxLength(500);
            builder.Property(x => x.ProductPicsPathes).IsRequired().HasMaxLength(100);
            builder.HasQueryFilter(x => x.IsExist); //default show only Exsiting(hide soft Deleted)
            builder.HasQueryFilter(x => x.IsExist);

            builder.HasOne(x => x.CartItem)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.SubCategory)
                 .WithMany()
                 .HasForeignKey(x => x.SubCategoryId)
                 .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Supplier)
                .WithMany()
                .HasForeignKey(x => x.SupplierId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.OrderItem)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
