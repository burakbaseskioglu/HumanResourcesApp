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
            using (var context = new ApplicationDbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Set<T>().Find(expression);
            }
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> expression = null)
        {
            using (var context = new ApplicationDbContext())
            {
                return expression == null ? context.Set<T>().ToList() : context.Set<T>().Where(expression).ToList();
            }
        }

        public void Insert(T entity)
        {
            using (var context = new ApplicationDbContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (var context = new ApplicationDbContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
