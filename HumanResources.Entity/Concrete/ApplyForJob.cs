using HumanResources.Entities.Abstract;

namespace HumanResources.Entities.Concrete
{
    public class ApplyForJob : BaseEntity
    {
        public Guid JobId { get; set; }
        public Job Job { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string CoverLetter { get; set; }
        public int Status { get; set; }
    }
}
