using HumanResources.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace HumanResources.Entities.Concrete
{
    public class UserDetail : BaseEntity
    {
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        public bool Gender { get; set; }

        [Required]
        public string PlaceOfBirth { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string MilitaryServiceStatus { get; set; }

        [Required]
        public string BloodType { get; set; }

        public string? MaritalStatus { get; set; }

        public string? DrivingLicense { get; set; }
        
    }
}
