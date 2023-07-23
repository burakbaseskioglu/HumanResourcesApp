using HumanResources.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace HumanResources.Entities.Concrete
{
    public class Course : BaseEntity
    {
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        public string CourseName { get; set; }

        [Required]
        public string Company { get; set; }

        [Required]
        public DateTime StartedDate { get; set; }
    }
}
