namespace _7oras.Domain.Interfaces
{
    #region benefits of UOW
    //-Reduces database round trips (all changes happen in memory and commited once to database)
    //-All operations succeed or fail together (same as transiction) ==Prevents partial updates
    //-Proper disposal of DbContext and free connection with database
    //-Use Dbcontext once so can change it , maintain it , test it without application layer(EntityManagment or Controllers  ) feels
    //-Facilitates unit testing
    #endregion
    public interface IUOW : IDisposable
    {
        IBaseRepo<Address> AddressRepo { get; }
        IBaseRepo<Cart> CartRepo { get; }
        IBaseRepo<CartItem> CartItemRepo { get; }
        IBaseRepo<Category> CategoryRepo { get; }
        IBaseRepo<Customer> CustomerRepo { get; }
        IBaseRepo<Message> MessageRepo { get; }
        IBaseRepo<Notification> NotificationRepo { get; }
        IBaseRepo<Order> OrderRepo { get; }
        IBaseRepo<OrderItem> OrderItemRepo { get; }
        IBaseRepo<OrderStatusHistory> OrderStatusHistoryRepo { get; }
        IBaseRepo<PaymentMethod> PaymentMethodRepo { get; }
        IBaseRepo<Person> PersonRepo { get; }
        IBaseRepo<Product> ProductRepo { get; }
        IBaseRepo<Report> ReportRepo { get; }
        IBaseRepo<Review> ReviewRepo { get; }
        IBaseRepo<SubCategory> SubCategoryRepo { get; }
        IBaseRepo<Supplier> SupplierRepo { get; }
        IBaseRepo<Wishlist> WishlistRepo { get; }

        Task<int> Complete();
    }
}
