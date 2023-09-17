namespace HumanResources.Entities.Dto.Auth;

public class RegisterDto
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string IdentityNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Nationality { get; set; }
    public string Password { get; set; }
    public string PasswordAgain { get; set; }
}
