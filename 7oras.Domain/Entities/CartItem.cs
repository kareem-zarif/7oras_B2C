namespace _7oras.Domain
{
    public class CartItem : BaseEnt
    {
        public int Quantity { get; set; }
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        [ForeignKey("Cart")]
        public Guid CartId { get; set; }
        //nav
        public virtual Product Product { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
