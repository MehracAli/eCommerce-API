using eCommerce.Application.Repositories;
using eCommerce.Domain.Entities.Common;
using eCommerce.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace eCommerce.Persistance.Concretes
{
    public class RepositoryWrite<T> : IRepositoryWrite<T> where T : BaseEntity, new()
    {
        private readonly AppDbContext _context;

        public RepositoryWrite(AppDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(model);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> model)
        {
            await Table.AddRangeAsync(model);
            return true;
        }

        public bool Remove(T model)
        {
            EntityEntry<T> entityEntry = Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> Remove(int Id)
        {
            T model = await Table.FirstOrDefaultAsync(t => t.Id == Id);
            return Remove(model);
        }

        public bool RemoveRange(List<T> model)
        {
            Table.RemoveRange(model);
            return true;
        }

        public async Task<bool> UpdateAsync(T model)
        {
            Table.Update(model);
            EntityEntry<T> entityEntry = Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }

        public async Task<int> SaveAsync()
        => await _context.SaveChangesAsync();
    }
}
