using _7oras.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _7oras.Infrastructure.EF.EntitiesConfiguration
{
    public class WishlistConfig : IEntityTypeConfiguration<Wishlist>
    {
        public void Configure(EntityTypeBuilder<Wishlist> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.HasData(
                new Wishlist
                {
                    Id = Guid.NewGuid(),
                    CustomerId = Guid.NewGuid()
                },
                new Wishlist
                {
                    Id = Guid.NewGuid(),
                    CustomerId = Guid.Parse("")
                }
            );
        }
    }
}
