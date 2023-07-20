using HumanResources.Entities.Dto.User;

namespace HumanResources.Entities.Dto.Work
{
    public class WorkDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public UserShortInfoDto User { get; set; }
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
