using _7oras.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _7oras.Infrastructure.EF.EntitiesConfiguration
{
    public class NotificationConfig : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Message).HasMaxLength(1000).IsRequired();
            builder.HasQueryFilter(x => x.IsExist);

        }
    }
}
