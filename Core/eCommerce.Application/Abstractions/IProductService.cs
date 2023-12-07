using eCommerce.Domain.Entities;

namespace eCommerce.Application.Abstractions
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
