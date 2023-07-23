using HumanResources.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace HumanResources.Entities.Concrete
{
    public class Work : BaseEntity
    {
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string Industry { get; set; }

        [Required]
        public string HowToWork { get; set; }

        [Required]
        public bool StillInThisBusiness { get; set; }

        [Required]
        public DateTime StartedDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        public string UnitWorked { get; set; }

        [Required]
        public string Position { get; set; }

        public string? ShortJobDescription { get; set; }
    }
}
