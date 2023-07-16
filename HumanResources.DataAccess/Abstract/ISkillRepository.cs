using HumanResources.DataAccess.Repository;
using HumanResources.Entities.Concrete;

namespace HumanResources.DataAccess.Abstract
{
    public interface ISkillRepository : IRepository<Skill>
    {
        List<Skill> GetAllSkillsWithUserInfo();
    }
}
