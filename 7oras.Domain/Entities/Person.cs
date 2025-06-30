namespace _7oras.Domain
{
    public class Person : BaseEnt
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        //nav
        public virtual ICollection<Address> Addresses { get; set; } = new HashSet<Address>();
    }
}
