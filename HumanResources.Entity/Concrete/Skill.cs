using HumanResources.Core;

namespace HumanResources.Entities.Concrete
{
    public class Skill : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string SkillName { get; set; }
        public string Level { get; set; }
    }
}
