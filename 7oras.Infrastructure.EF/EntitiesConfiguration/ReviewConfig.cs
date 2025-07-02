using _7oras.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _7oras.Infrastructure.EF.EntitiesConfiguration
{
    public class ReviewConfig : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Rating).IsRequired();
            builder.Property(x => x.Comment).IsRequired(false).HasMaxLength(500);

            builder.HasData(
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 5,
                    Comment = "Excellent product!",
                    CustomerId = Guid.NewGuid(),
                    PrdouctId = Guid.NewGuid()
                },
                new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = 3,
                    Comment = "Average quality.",
                    CustomerId = Guid.NewGuid(),
                    PrdouctId = Guid.NewGuid()
                }
            );
        }
    }
}
