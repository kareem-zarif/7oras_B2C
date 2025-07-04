namespace _7oras.Infrastructure.EF
{
    public class UOW : IUOW
    {
        private readonly AppDbContext _context;

        private IBaseRepo<Address> _addressRepo;
        private IBaseRepo<Cart> _cartRepo;
        private IBaseRepo<CartItem> _cartItemRepo;
        private ICategoryRepo _categoryRepo;
        private IBaseRepo<Customer> _customerRepo;
        private IBaseRepo<Message> _messageRepo;
        private IBaseRepo<Notification> _notificationRepo;
        private IBaseRepo<Order> _orderRepo;
        private IBaseRepo<OrderItem> _orderItemRepo;
        private IBaseRepo<OrderStatusHistory> _orderStatusHistoryRepo;
        private IBaseRepo<PaymentMethod> _paymentMethodRepo;
        private IBaseRepo<Person> _personRepo;
        private IBaseRepo<Product> _productRepo;
        private IBaseRepo<Report> _reportRepo;
        private IBaseRepo<Review> _reviewRepo;
        private ISubCategoryRepo _subCategoryRepo;
        private IBaseRepo<Supplier> _supplierRepo;
        private IBaseRepo<Wishlist> _wishlistRepo;
        public UOW( //using addScoped => auto pass the IRepos for the constructor for every instance of dbcontext
            AppDbContext context,
            IBaseRepo<Address> addressRepo,
            IBaseRepo<Cart> cartRepo,
            IBaseRepo<CartItem> cartItemRepo,
            ICategoryRepo categoryRepo,
            IBaseRepo<Customer> customerRepo,
            IBaseRepo<Message> messageRepo,
            IBaseRepo<Notification> notificationRepo,
            IBaseRepo<Order> orderRepo,
            IBaseRepo<OrderItem> orderItemRepo,
            IBaseRepo<OrderStatusHistory> orderStatusHistoryRepo,
            IBaseRepo<PaymentMethod> paymentMethodRepo,
            IBaseRepo<Person> personRepo,
            IBaseRepo<Product> productRepo,
            IBaseRepo<Report> reportRepo,
            IBaseRepo<Review> reviewRepo,
            ISubCategoryRepo subCategoryRepo,
            IBaseRepo<Supplier> supplierRepo,
            IBaseRepo<Wishlist> wishlistRepo)
        {
            _context = context;
            _addressRepo = addressRepo;
            _cartRepo = cartRepo;
            _cartItemRepo = cartItemRepo;
            _categoryRepo = categoryRepo;
            _customerRepo = customerRepo;
            _messageRepo = messageRepo;
            _notificationRepo = notificationRepo;
            _orderRepo = orderRepo;
            _orderItemRepo = orderItemRepo;
            _orderStatusHistoryRepo = orderStatusHistoryRepo;
            _paymentMethodRepo = paymentMethodRepo;
            _personRepo = personRepo;
            _productRepo = productRepo;
            _reportRepo = reportRepo;
            _reviewRepo = reviewRepo;
            _subCategoryRepo = subCategoryRepo;
            _supplierRepo = supplierRepo;
            _wishlistRepo = wishlistRepo;
        }

        public IBaseRepo<Address> AddressRepo => _addressRepo;
        public IBaseRepo<Cart> CartRepo => _cartRepo;
        public IBaseRepo<CartItem> CartItemRepo => _cartItemRepo;
        public ICategoryRepo CategoryRepo => _categoryRepo;
        public IBaseRepo<Customer> CustomerRepo => _customerRepo;
        public IBaseRepo<Message> MessageRepo => _messageRepo;
        public IBaseRepo<Notification> NotificationRepo => _notificationRepo;
        public IBaseRepo<Order> OrderRepo => _orderRepo;
        public IBaseRepo<OrderItem> OrderItemRepo => _orderItemRepo;
        public IBaseRepo<OrderStatusHistory> OrderStatusHistoryRepo => _orderStatusHistoryRepo;
        public IBaseRepo<PaymentMethod> PaymentMethodRepo => _paymentMethodRepo;
        public IBaseRepo<Person> personRepo => _personRepo;
        public IBaseRepo<Person> PersonRepo => _personRepo;
        public IBaseRepo<Product> ProductRepo => _productRepo;
        public IBaseRepo<Report> ReportRepo => _reportRepo;
        public IBaseRepo<Review> ReviewRepo => _reviewRepo;
        public ISubCategoryRepo SubCategoryRepo => _subCategoryRepo;
        public IBaseRepo<Supplier> SupplierRepo => _supplierRepo;
        public IBaseRepo<Wishlist> WishlistRepo => _wishlistRepo;

        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()//call GC finalizer and prevent derived classes to call it again
        {
            _context.Dispose();
        }
    }
}
