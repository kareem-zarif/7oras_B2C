using _7oras.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _7oras.Infrastructure.EF.EntitiesConfiguration
{
     public class MessageConfig : IEntityTypeConfiguration<Message>
     {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Body).HasMaxLength(500).IsRequired(false);

            builder.HasData(
                new Message
                {
                    Id = Guid.NewGuid(),
                    Body = "Hello, this is a test message.",
                    CustomerId = Guid.NewGuid(),
                    SupplierId = Guid.NewGuid()  
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    Body = "Another test message for validation.",
                    CustomerId = Guid.NewGuid(), 
                    SupplierId = Guid.NewGuid()  
                }
            );
        }
    }
}
