using Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstractions
{
    public interface IRepository<TEntity> where TEntity : class
    {
        ICollection<T> GetAll<T>()
            where T : BaseEntity;

        T GetByFilter<T>(Expression<Func<T, bool>> filter)
            where T : BaseEntity;

        ICollection<T> GetAllByFilter<T>(Expression<Func<T, bool>> filter)
            where T : BaseEntity;

        void Insert<T>(T entity)
            where T : BaseEntity;

        void Update<T>(T entity)
            where T : BaseEntity;

        void Save();

        void Delete<T>(T entity)
            where T : BaseEntity;
    }
}

