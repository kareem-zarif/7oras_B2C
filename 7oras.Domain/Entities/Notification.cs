namespace _7oras.Domain
{
    public class Notification : BaseEnt
    {
        public string Message { get; set; }
        public bool IsRead { get; set; }
        //nav 
        public virtual Customer Customer { get; set; }
    }
}
