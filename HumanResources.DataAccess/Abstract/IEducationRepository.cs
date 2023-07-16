using HumanResources.DataAccess.Repository;
using HumanResources.Entities.Concrete;
using System.Linq.Expressions;

namespace HumanResources.DataAccess.Abstract
{
    public interface IEducationRepository : IRepository<Education>
    {
        List<Education> GetAllEducationsWithUserInfo(Expression<Func<Education, bool>> expression = null);
    }
}
