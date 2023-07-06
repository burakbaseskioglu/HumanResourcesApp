using HumanResources.Entities.Abstract;
using System.Linq.Expressions;

namespace HumanResources.DataAccess.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(Expression<Func<T, bool>> expression);
        IEnumerable<T> GetAll(Expression<Func<T, bool>> expression = null);
    }
}
