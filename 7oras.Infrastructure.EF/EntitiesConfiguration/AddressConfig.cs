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
    public class AddressConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Country).HasMaxLength(50).IsRequired();
            builder.HasOne(x => x.Person)
                .WithMany(p => p.Addresses)
                .HasForeignKey(x => x.PersonId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new Address
                {
                    Id = Guid.NewGuid(),
                    Street = "123 Main St",
                    City = "Cairo",
                    State = "Cairo",
                    PostalCode = "12345",
                    Country = "Egypt",
                    PersonId = Guid.NewGuid() // دا هيتبدل ب personId من جدول person
                },
                new Address
                {
                    Id = Guid.NewGuid(),
                    Street = "456 Elm St",
                    City = "Alexandria",
                    State = "Alexandria",
                    PostalCode = "54321",
                    Country = "Egypt",
                    PersonId = Guid.NewGuid() // نفس الكلام هنا زي الي فوق
                }
            );
        }
    }
}
