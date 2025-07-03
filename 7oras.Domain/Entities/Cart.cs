namespace _7oras.Domain
{
    public class Cart : BaseEnt
    {
        [ForeignKey("Customer")]
        public Guid CustomerId { get; set; }
        //nav
        public virtual Customer Customer { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; } = new HashSet<CartItem>();
    }
}
