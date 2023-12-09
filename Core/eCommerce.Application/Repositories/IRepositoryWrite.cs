using eCommerce.Domain.Entities.Common;

namespace eCommerce.Application.Repositories
{
    public interface IRepositoryWrite<T> : IRepository<T> where T : BaseEntity, new()
    {
        Task<bool> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> model);
        bool Remove(T model);
        bool RemoveRange(List<T> model);
        Task<bool> Remove(int Id);
        Task<bool> UpdateAsync(T model);
        Task<int> SaveAsync();
    }
}
