namespace HumanResources.Entities.Dto.User;

public class UserDto
{
    public Guid Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public long IdentityNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Nationality { get; set; }
}
