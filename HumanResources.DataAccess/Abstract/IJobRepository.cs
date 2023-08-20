using HumanResources.DataAccess.Repository;
using HumanResources.Entities.Concrete;

namespace HumanResources.DataAccess.Abstract
{
    public interface IJobRepository : IRepository<Job>
    {
        public List<Job> GetJobs();
    }
}
