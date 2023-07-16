using HumanResources.DataAccess.Abstract;
using HumanResources.DataAccess.Repository.EntityFramework;
using HumanResources.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq.Expressions;

namespace HumanResources.DataAccess.Concrete
{
    public class EducationRepository : EfRepositoryBase<Education>, IEducationRepository
    {
        private readonly IConfiguration _configuration;
        public EducationRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        public List<Education> GetAllEducationsWithUserInfo(Expression<Func<Education, bool>> expression = null)
        {
            using (ApplicationDbContext context = new(_configuration))
            {
                return expression == null ?
                    context.Educations
                    .Include(x => x.User)
                    .Include(x => x.EducationDegree)
                    .Include(x => x.EducationType).ToList() :
                    context.Educations
                    .Include(x => x.User)
                    .Include(x => x.EducationDegree)
                    .Include(x => x.EducationType).Where(expression).ToList();
            }
        }
    }
}
