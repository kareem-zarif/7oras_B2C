namespace _7oras.Domain
{
    public class Supplier : Person
    {
        //prebuit questions will be in json-file
        public string FactoryName { get; set; }
        public string? Description { get; set; }
        public string? IFactoryPicPath { get; set; }
        public string? BankAccountName { get; set; }
        public string? BankAccountNumber { get; set; }
        public bool IsBlocked { get; set; } = false;
        public DateTime? BlockUntil { get; set; } //nullable value type and not need write it isrequied(false) in fluent api
        //nav
        public virtual ICollection<Product> Suppliers { get; set; } = new HashSet<Product>();
        public virtual ICollection<Address> Addresses { get; set; } = new HashSet<Address>();
        public virtual ICollection<Message> Messages { get; set; } = new HashSet<Message>();
    }
}
