using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HumanResources.Core.DataAccess.Repository.EntityFramework
{
    public class EfRepositoryBase<T, TContext> : IRepository<T>, IDisposable where T : BaseEntity where TContext : DbContext, new()
    {
        public void Delete(T entity)
        {
            using (var _context = new TContext())
            {
                var deletedEntity = _context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            using (var _context = new TContext())
            {
                return _context.Set<T>().Find(expression)!;
            }
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> expression = null)
        {
            using (var _context = new TContext())
            {
                return expression == null ? _context.Set<T>().ToList() : _context.Set<T>().Where(expression).ToList();
            }
        }

        public void Insert(T entity)
        {
            using (var _context = new TContext())
            {
                var addedEntity = _context.Entry(entity);
                addedEntity.State = EntityState.Added;
                _context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (var _context = new TContext())
            {
                var updatedEntity = _context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }
            if (disposing)
            {

            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
