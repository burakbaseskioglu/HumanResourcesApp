using HumanResources.Core;

namespace HumanResources.Entities.Concrete
{
    public class Language : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string LanguageName { get; set; }
        public string Level { get; set; }
    }
}
