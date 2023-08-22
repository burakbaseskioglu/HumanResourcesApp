using HumanResources.DataAccess.Abstract;
using HumanResources.DataAccess.Repository.EntityFramework;
using HumanResources.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace HumanResources.DataAccess.Concrete
{
    public class JobRepository : EfRepositoryBase<Job>, IJobRepository
    {
        private readonly IConfiguration _configuration;
        public JobRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        public List<Job> GetJobs(List<Guid>? ids = null)
        {
            using (var context = new ApplicationDbContext(_configuration))
            {
                var jobs = context.Jobs.Include(x => x.Workspace).Where(x => !x.DeletedDate.HasValue);

                return ids.Any() ? jobs.Where(x => ids.Contains(x.WorkspaceId)).ToList() : jobs.ToList();

            }
        }
    }
}
