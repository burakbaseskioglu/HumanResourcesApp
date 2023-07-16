using HumanResources.DataAccess.Abstract;
using HumanResources.DataAccess.Repository.EntityFramework;
using HumanResources.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HumanResources.DataAccess.Concrete
{
    public class SkillRepository : EfRepositoryBase<Skill>, ISkillRepository
    {
        private readonly IConfiguration _configuration;
        public SkillRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        public List<Skill> GetAllSkillsWithUserInfo()
        {
            using (ApplicationDbContext context = new(_configuration))
            {
                return context.Skills.Include(x => x.User).ToList();
            }
        }
    }
}
