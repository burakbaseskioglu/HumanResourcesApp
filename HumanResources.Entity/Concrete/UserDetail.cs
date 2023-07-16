using HumanResources.Entities.Abstract;

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
        
    }
}
