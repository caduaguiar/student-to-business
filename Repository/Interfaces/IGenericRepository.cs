using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repositorio
{
    public interface IGenericRepository<T> where T : class 
    {
        IQueryable<T> AsQueryable();
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> where);
        T Single(Expression<Func<T, bool>> where);
        T First(Expression<Func<T, bool>> where);
        void Delete(T entity);
        void Delete(Func<T, bool> where);
        void Add(T entity);
        void Update(T entity);
    }
}
