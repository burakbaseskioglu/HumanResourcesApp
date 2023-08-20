using HumanResources.Entities.Abstract;

namespace HumanResources.Entities.Concrete
{
    public class Workspace : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Job> Jobs { get; set; }
    }
}
