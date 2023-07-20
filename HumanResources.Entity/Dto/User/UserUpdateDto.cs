namespace HumanResources.Entities.Dto.User;

public class UserUpdateDto
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Password { get; set; }
    public string PasswordAgain { get; set; }
}
