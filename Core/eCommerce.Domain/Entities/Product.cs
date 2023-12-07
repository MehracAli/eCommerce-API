using eCommerce.Domain.Entities.Common;

namespace eCommerce.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }

        ICollection<Order> Orders { get; set; }

        public Product() 
        {
            Orders = new List<Order>();
        }
    }
}
