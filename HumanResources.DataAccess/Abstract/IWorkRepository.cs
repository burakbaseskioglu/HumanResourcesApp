using HumanResources.DataAccess.Repository;
using HumanResources.Entities.Concrete;
using System.Linq.Expressions;

namespace HumanResources.DataAccess.Abstract
{
    public interface IWorkRepository : IRepository<Work>
    {
        List<Work> GetAllWorksWithUserInfo(Expression<Func<Work, bool>> expression = null);
    }
}
