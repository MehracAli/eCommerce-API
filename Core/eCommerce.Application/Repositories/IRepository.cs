using eCommerce.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity, new()
    {
        DbSet<T> Table {  get; }
    }
}
