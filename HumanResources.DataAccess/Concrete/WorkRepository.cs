using HumanResources.DataAccess.Abstract;
using HumanResources.DataAccess.Repository.EntityFramework;
using HumanResources.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq.Expressions;

namespace HumanResources.DataAccess.Concrete
{
    public class WorkRepository : EfRepositoryBase<Work>, IWorkRepository
    {
        private readonly IConfiguration _configuration;
        public WorkRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        public List<Work> GetAllWorksWithUserInfo(Expression<Func<Work, bool>> expression = null)
        {
            using (ApplicationDbContext context = new(_configuration))
            {
                return expression == null ? context.Works.Include(x => x.User).ToList() : context.Works.Include(x => x.User).Where(expression).ToList();
            }
        }
    }
}
