using HumanResources.DataAccess.Abstract;
using HumanResources.DataAccess.Repository.EntityFramework;
using HumanResources.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HumanResources.DataAccess.Concrete
{
    public class WorkRepository : EfRepositoryBase<Work>, IWorkRepository
    {
        private readonly IConfiguration _configuration;
        public WorkRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        public List<Work> GetAllWorksWithUserInfo()
        {
            using (ApplicationDbContext context = new(_configuration))
            {
                return context.Works.Include(x => x.User).ToList();
            }
        }
    }
}
