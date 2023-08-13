namespace HumanResources.Entities.Dto.User
{
    public class UserDetailDto
    {
        public Guid UserId { get; set; }
        public bool Gender { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Address { get; set; }
        public string MilitaryServiceStatus { get; set; }
        public DateTime? MilitaryServiceStatusDate { get; set; }
        public string BloodType { get; set; }
        public string? MaritalStatus { get; set; }
        public string? DrivingLicense { get; set; }
    }
}
