namespace HumanResources.Entities.Dto.User
{
    public class UserDetailInsertOrUpdateDto
    {
        public Guid UserId { get; set; }

        public bool Gender { get; set; }

        public string PlaceOfBirth { get; set; }

        public string Address { get; set; }

        public int MilitaryServiceStatus { get; set; }

        public DateTime? MilitaryServiceStatusDate { get; set; }

        public string BloodType { get; set; }

        public int? MaritalStatus { get; set; }

        public string? DrivingLicense { get; set; }
    }
}
