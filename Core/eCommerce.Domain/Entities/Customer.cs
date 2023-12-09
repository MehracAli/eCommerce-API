using eCommerce.Domain.Entities.Common;

namespace eCommerce.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
        
        public Customer()
        {
            Orders = new List<Order>();
        }
    }
}
