using HumanResources.DataAccess.Abstract;
using HumanResources.DataAccess.Repository.EntityFramework;
using HumanResources.Entities.Concrete;
using Microsoft.Extensions.Configuration;

namespace HumanResources.DataAccess.Concrete
{
    public class SkillRepository : EfRepositoryBase<Skill>, ISkillRepository
    {
        public SkillRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
