using HumanResources.Entities.Abstract;

namespace HumanResources.Entities.Concrete
{
    public class Work : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string CompanyName { get; set; }
        public string Industry { get; set; }
        public string HowToWork { get; set; }
        public bool StillInThisBusiness { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndDate { get; set; }
        public string UnitWorked { get; set; }
        public string Position { get; set; }
        public string ShortJobDescription { get; set; }
    }
}
