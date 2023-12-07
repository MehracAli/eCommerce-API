using eCommerce.Domain.Entities.Common;

namespace eCommerce.Domain.Entities
{
    public class Order : BaseEntity
    {
        public string Description { get; set; }
        public string Addres { get; set; }

        ICollection<Product> Products { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public Order()
        {
            Products = new List<Product>();
        }
    }
}
