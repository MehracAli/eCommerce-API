using eCommerce.Domain.Entities.Common;
using System.Linq.Expressions;

namespace eCommerce.Application.Repositories
{
    public interface IRepositoryRead<T> : IRepository<T> where T : BaseEntity, new()
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method);
        Task<T> GetByIdAsync(int id);
    }
}
