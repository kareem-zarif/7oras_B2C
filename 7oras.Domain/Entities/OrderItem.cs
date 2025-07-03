namespace _7oras.Domain
{
    public class OrderItem : BaseEnt
    {
        public int Quantity { get; set; }
        public double UnitPrice { get; set; } //price at time of purchase
        public bool IsSample { get; set; }
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        [ForeignKey("Order")]
        public Guid? OrderId { get; set; }
        //nav
        public virtual Product Product { get; set; }
        public virtual Order? Order { get; set; }

    }
}
