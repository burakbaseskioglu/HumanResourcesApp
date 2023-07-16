using HumanResources.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq.Expressions;

namespace HumanResources.DataAccess.Repository.EntityFramework
{
    public class EfRepositoryBase<T> : IRepository<T>, IDisposable where T : BaseEntity
    {
        private static ApplicationDbContext _context;
        private DbSet<T> _entities;

        private readonly IConfiguration _configuration;

        public EfRepositoryBase(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Delete(T entity)
        {
            using (_context = new(_configuration))
            {
                var deletedEntity = _context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                entity.DeletedDate = DateTime.Now;
                entity.DeletedUser = Guid.NewGuid();
                _context.SaveChanges();
            }
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            using (_context = new(_configuration))
            {
                return _context.Set<T>().FirstOrDefault(expression)!;
            }
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> expression = null)
        {
            using (_context = new(_configuration))
            {
                return expression == null ? _context.Set<T>().ToList() : _context.Set<T>().Where(expression).ToList();
            }
        }

        public void Insert(T entity)
        {
            using (_context = new(_configuration))
            {
                var addedEntity = _context.Entry(entity);
                addedEntity.State = EntityState.Added;
                entity.CreatedDate = DateTime.Now;
                entity.CreatedUser = Guid.NewGuid();
                _context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (_context = new(_configuration))
            {
                var updatedEntity = _context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                entity.ModifiedDate = DateTime.Now;
                entity.ModifiedUser = Guid.NewGuid();
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

        public void SoftDelete(T entity)
        {
            using (_context = new(_configuration))
            {
                var deletedEntity = _context.Entry(entity);
                entity.DeletedDate = DateTime.Now;
                entity.DeletedUser = Guid.NewGuid();
                deletedEntity.State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public IQueryable<T> IncludeMany(Expression<Func<T, object>> include)
        {
            using (_context = new(_configuration))
            {
                _entities = _context.Set<T>();
                return _entities.Include(include);
            }
        }
    }
}
