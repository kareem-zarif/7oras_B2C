using System.ComponentModel.DataAnnotations.Schema;

namespace _7oras.Domain
{
    public class Order : BaseEnt
    {
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
        [ForeignKey("PaymentMethod")]
        public Guid PaymentMethodId { get; set; }
        [ForeignKey("Customer")]
        public Guid CustomerId { get; set; }
        //nav
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();
    }
}
