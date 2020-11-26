using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WarehouseApp.Data.Common;

namespace WarehouseApp.Data
{
    public class DbRepository<TEntity> : IRepository<TEntity>, IDisposable
        where TEntity : class
    {
        private readonly WarehouseAppDbContext context;
        private DbSet<TEntity> dbSet;

        public DbRepository(WarehouseAppDbContext context)
        {
            this.context = context;
            this.dbSet = this.context.Set<TEntity>();
        }

        public Task AddAsync(TEntity entity)
        {
            return this.dbSet.AddAsync(entity);
        }

        public IQueryable<TEntity> All()
        {
            return this.dbSet;
        }

        public void Delete(TEntity entity)
        {
            this.dbSet.Remove(entity);
        }

        public void Dispose()
        {
            this.context.Dispose();
        }

        public Task<int> SaveChangesAsync()
        {
            return this.context.SaveChangesAsync();
        }
    }
}
