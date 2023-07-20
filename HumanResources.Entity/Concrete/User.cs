using HumanResources.Entities.Abstract;

namespace HumanResources.Entities.Concrete;

public class User : BaseEntity
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public long IdentityNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Nationality { get; set; }
    public string Password { get; set; }
    public string PasswordAgain { get; set; }
    public ICollection<Education> Educations { get; set; }
    public ICollection<Work>? Works { get; set; }
    public ICollection<Language>? Languages { get; set; }
    public ICollection<Certificate>? Certificates { get; set; }
    public ICollection<Course>? Courses { get; set; }
    public ICollection<Skill>? Skills { get; set; }
}
