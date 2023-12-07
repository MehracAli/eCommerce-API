using eCommerce.Application.Abstractions;
using eCommerce.Domain.Entities;

namespace eCommerce.Persistance.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        => new()
        {
            new() {Id = 1},
            new() {Id = 2},
            new() {Id = 3},
            new() {Id = 4},
        };
    }
}
