using _7oras.Domain;
using _7oras.Domain.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _7oras.Infrastructure.EF.EntitiesConfiguration
{
    public class PaymentMethodConfig : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.PaymentType).IsRequired();

            builder.HasData(
                new PaymentMethod
                {
                    Id = Guid.NewGuid(),
                    PaymentType = PaymentMethodType.Instapay,
                    CardNumber = "1234567890123456",
                    CardHolderName = "John Doe",
                    ExpireDate = "12/25",
                    CVV = "123",
                    CustomerId = Guid.NewGuid()
                },
                new PaymentMethod
                {
                    Id = Guid.NewGuid(),
                    PaymentType = PaymentMethodType.VisaCard,
                    CardNumber = "9876543210987654",
                    CardHolderName = "Jane Smith",
                    ExpireDate = "11/24",
                    CVV = "456",
                    CustomerId = Guid.NewGuid()
                }
            );

        }
    }
}
