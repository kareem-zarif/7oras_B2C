namespace _7oras.Domain
{
    public class Report : BaseEnt
    {
        public string? Reason { get; set; }
        public Guid CustomerId { get; set; }
        public Guid SupplierId { get; set; }
        //nav
        public virtual Customer Customer { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
