using HumanResources.Entities.Abstract;
using HumanResources.Entities.Enums;
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

        public MaritalStatus? MaritalStatus { get; set; }

        [Required]
        public int MilitaryServiceStatus { get; set; }

        public DateTime? MilitaryServiceStatusDate { get; set; }

        [Required]
        public string BloodType { get; set; }

        public string? DrivingLicense { get; set; }
    }
}
