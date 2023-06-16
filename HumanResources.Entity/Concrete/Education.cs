using HumanResources.Core;

namespace HumanResources.Entities.Concrete
{
    public class Education : BaseEntity
    {
        public string EducationTypeId { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string EducationLevel { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string EducationType { get; set; }
        public string Faculty { get; set; }
        public string GraduationDegree { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
