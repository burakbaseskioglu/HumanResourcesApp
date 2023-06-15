using HumanResources.DataAccess;
using HumanResources.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HumanResources.Core.DataAccess.Repository.EntityFramework
{
    public class EfRepositoryBase<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        public EfRepositoryBase(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Delete(T entity)
        {
            var deletedEntity = _context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Find(expression);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> expression = null)
        {
            return expression == null ? _context.Set<T>().ToList() : _context.Set<T>().Where(expression).ToList();
        }

        public void Insert(T entity)
        {
            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            var updatedEntity = _context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
