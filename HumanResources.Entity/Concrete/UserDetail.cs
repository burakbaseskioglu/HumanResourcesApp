using HumanResources.Core;

namespace HumanResources.Entities.Concrete
{
    public class UserDetail : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public bool Gender { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Address { get; set; }
        public string MilitaryServiceStatus { get; set; }
        public string BloodType { get; set; }
        public string? MaritalStatus { get; set; }
        public string? DrivingLicense { get; set; }
        public ICollection<Education> Educations { get; set; }
        public ICollection<Work>? Works { get; set; }
        public ICollection<Language>? Languages { get; set; }
        public ICollection<Certificate>? Certificates { get; set; }
        public ICollection<Course>? Courses { get; set; }
        public ICollection<Skill>? Skills { get; set; }
    }
}
