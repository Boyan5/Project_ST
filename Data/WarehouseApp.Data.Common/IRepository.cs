﻿using System;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseApp.Data.Common
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        IQueryable<TEntity> All();

        TEntity AddAsync(TEntity entity);

        void Delete(TEntity entity);

        Task<int> SaveChangesAsync();
    }
}
