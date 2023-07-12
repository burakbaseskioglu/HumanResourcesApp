using HumanResources.DataAccess.Abstract;
using HumanResources.DataAccess.Repository.EntityFramework;
using HumanResources.Entities.Concrete;
using Microsoft.Extensions.Configuration;

namespace HumanResources.DataAccess.Concrete
{
    public class WorkRepository : EfRepositoryBase<Work>, IWorkRepository
    {
        public WorkRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
