using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WarehouseApp.Data.Common;

namespace WarehouseApp.Data
{
    public class DbRepository<TEntity> : IRepository<TEntity>, IDisposable
        where TEntity : class, ICreatable
    {
        private readonly WarehouseAppDbContext context;
        private readonly DbSet<TEntity> dbSet;

        public DbRepository(WarehouseAppDbContext context)
        {
            this.context = context;
            this.dbSet = this.context.Set<TEntity>();
        }

        public TEntity GetById<T>(T id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public TEntity AddAsync(TEntity entity)
        {
            entity.CreatedOn = DateTime.UtcNow;
            this.dbSet.AddAsync(entity);
            this.context.SaveChanges();
            return entity;
           
        }

        public IQueryable<TEntity> All()
        {
            return this.dbSet;
        }

        public IEnumerable<TEntity> AllEnum()
        {
            return this.dbSet.AsEnumerable();
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
