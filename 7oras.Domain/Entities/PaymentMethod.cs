using _7oras.Domain.Shared;

namespace _7oras.Domain
{
    public class PaymentMethod : BaseEnt
    {
        public PaymentMethodType PaymentType { get; set; }
        public bool IsDefault { get; set; } = false;
        //INstapay

        //Visa
        public string? CardNumber { get; set; }
        public string? CardHolderName { get; set; }
        public string? ExpireDate { get; set; }
        public string? CVV { get; set; }
        //vodafoneCash , OrangeCash
        public string? PhoneNumber { get; set; }
        //fawry
        public string? FawryCode { get; set; }

        public Guid CustomerId { get; set; }
        //nav
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();

    }
}
