using _7oras.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _7oras.Infrastructure.EF.EntitiesConfiguration
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.HasData(
                new Order
                {
                    Id = Guid.NewGuid(),
                    OrderDate = DateTime.UtcNow,
                    TotalAmount = 100.0,
                    PaymentMethodId = Guid.NewGuid(), 
                    CustomerId = Guid.NewGuid() 
                },
                new Order
                {
                    Id = Guid.NewGuid(),
                    OrderDate = DateTime.UtcNow,
                    TotalAmount = 200.0,
                    PaymentMethodId = Guid.NewGuid(),
                    CustomerId = Guid.NewGuid() 
                }
            );
        }
    }
}
