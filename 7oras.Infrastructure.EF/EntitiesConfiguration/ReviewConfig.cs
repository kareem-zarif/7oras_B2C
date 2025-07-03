namespace _7oras.Infrastructure.EF.EntitiesConfiguration
{
    public class ReviewConfig : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Comment).IsRequired(false).HasMaxLength(500);
            builder.HasQueryFilter(x => x.IsExist);

        }
    }
}
