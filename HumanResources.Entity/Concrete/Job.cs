using HumanResources.Entities.Abstract;

namespace HumanResources.Entities.Concrete
{
    public class Job : BaseEntity
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime EndDate { get; set; }
        public int WorkType { get; set; }
        public Guid WorkspaceId { get; set; }
        public Workspace Workspace { get; set; }
    }
}
