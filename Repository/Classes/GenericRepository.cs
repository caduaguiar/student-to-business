using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Repositorio.Interfaces;

namespace Repositorio
{
    public class GenericRepository<T> : IDisposable, IGenericRepository<T> where T : class
    {
        protected readonly DbBanco UnidadeDeTrabalho;

        public GenericRepository(IUnidadeDeTrabalho unidadeDeTrabalho)
        {
            if(unidadeDeTrabalho == null)
                throw new ArgumentNullException("unidadeDeTrabalho");
            UnidadeDeTrabalho = unidadeDeTrabalho as DbBanco;
            UnidadeDeTrabalho.Configuration.ValidateOnSaveEnabled = false;
            UnidadeDeTrabalho.Configuration.AutoDetectChangesEnabled = true;
            UnidadeDeTrabalho.Configuration.LazyLoadingEnabled = false;
        }

        public IQueryable<T> AsQueryable()
        {
            return UnidadeDeTrabalho.Set<T>().AsQueryable();
        }

        public IEnumerable<T> GetAll()
        {
            return UnidadeDeTrabalho.Set<T>().ToList();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> where)
        {
            return UnidadeDeTrabalho.Set<T>().Where(where);
        }

        public T Single(Expression<Func<T, bool>> where)
        {
            return UnidadeDeTrabalho.Set<T>().Single(where);
        }

        public T First(Expression<Func<T, bool>> where)
        {
            return UnidadeDeTrabalho.Set<T>().First(where);
        }

        public void Delete(T entity)
        {
            UnidadeDeTrabalho.Set<T>().Remove(entity);
            UnidadeDeTrabalho.Commit();
        }

        public void Delete(Func<T, bool> predicate)
        {
            var entidades = from x in UnidadeDeTrabalho.Set<T>().Where(predicate) select x;
            foreach (var entidade in entidades)
            {
                UnidadeDeTrabalho.Set<T>().Attach(entidade);
                UnidadeDeTrabalho.Entry(entidade).State = EntityState.Deleted;
                UnidadeDeTrabalho.Set<T>().Remove(entidade);
            }
            UnidadeDeTrabalho.Commit();
        }

        public void Add(T entity)
        {
            UnidadeDeTrabalho.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            if (UnidadeDeTrabalho.Entry(entity).State == EntityState.Detached)
                UnidadeDeTrabalho.Set<T>().Attach(entity);
            UnidadeDeTrabalho.Entry(entity).State = EntityState.Modified;
        }

        #region IDisposable

        private bool _disposed;

        private void Dispose(bool disposing)
        {
            if (!disposing)
                return;

            if (_disposed)
                return;

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}