using eCommerce.Application.Repositories;
using eCommerce.Domain.Entities.Common;
using eCommerce.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace eCommerce.Persistance.Concretes
{
    public class RepositoryRead<T> : IRepositoryRead<T> where T : BaseEntity, new()
    {
        private readonly AppDbContext _context;

        public RepositoryRead(AppDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
        => Table;

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
        => Table.Where(method);

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
        => await Table.FirstOrDefaultAsync(method);

        public async Task<T> GetByIdAsync(int id)
        => await Table.FirstOrDefaultAsync(t => t.Id.Equals(id));

    }
}
