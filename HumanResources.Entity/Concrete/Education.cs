using HumanResources.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace HumanResources.Entities.Concrete
{
    public class Education : BaseEntity
    {
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public int EducationStatus { get; set; }

        [Required]
        public string Faculty { get; set; }

        public string GraduationDegree { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        public Guid EducationTypeId { get; set; }

        [Required]
        public EducationType EducationType { get; set; }

        [Required]
        public Guid EducationDegreeId { get; set; }

        [Required]
        public EducationDegree EducationDegree { get; set; }
    }
}
