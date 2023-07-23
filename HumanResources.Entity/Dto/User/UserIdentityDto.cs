namespace HumanResources.Entities.Dto.User
{
    public class UserIdentityDto
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public long IdentityNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string Nationality { get; set; }
    }
}
