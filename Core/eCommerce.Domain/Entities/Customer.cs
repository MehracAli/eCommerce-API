using eCommerce.Domain.Entities.Common;

namespace eCommerce.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Customer> Customers { get; set; }
        
        public Customer()
        {
            Customers = new List<Customer>();
        }
    }
}
