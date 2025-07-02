namespace _7oras.Infrastructure.EF.EntitiesConfiguration
{
    public class CartItemConfig : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Quantity).IsRequired(true);

            builder.HasData(
                new CartItem
                {
                    Id = Guid.NewGuid(),
                    Quantity = 2,
                    ProductId = Guid.NewGuid(),
                    CartId = Guid.NewGuid()
                },
                new CartItem
                {
                    Id = Guid.NewGuid(),
                    Quantity = 3,
                    ProductId = Guid.NewGuid(),
                    CartId = Guid.NewGuid()
                }
            );
        }
    }
}