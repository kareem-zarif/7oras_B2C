using _7oras.Domain.Shared;
using System.ComponentModel.DataAnnotations.Schema;

namespace _7oras.Domain
{
    public class Product : BaseEnt
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double PricePerPiece { get; set; }
        public double? PricePer50Piece { get; set; }
        public double? PricePer100Piece { get; set; }
        public int NoINStock { get; set; }
        public int MinNumToFactoryOrder { get; set; }
        public IList<string> ProductPicsPathes { get; set; }
        //extra details 
        public int? WarrantyNMonths { get; set; }
        public ShippingTypes Shipping { get; set; } = ShippingTypes.None;
        [ForeignKey("SubCategory")]
        public Guid SubCategoryId { get; set; }
        [ForeignKey("Supplier")]
        public Guid SupplierId { get; set; }
        //nav
        public virtual SubCategory SubCategory { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual CartItem CartItem { get; set; }
        public virtual Wishlist Wishlist { get; set; }
        public virtual OrderItem OrderItem { get; set; }
        public virtual ICollection<Review> Reviews { get; set; } = new HashSet<Review>();

    }
}
