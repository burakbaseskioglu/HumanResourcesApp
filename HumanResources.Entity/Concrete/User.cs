using HumanResources.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace HumanResources.Entities.Concrete;

public class User : BaseEntity
{
    [Required]
    public string Firstname { get; set; }

    [Required]
    public string Lastname { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Phone { get; set; }

    [Required]
    public long IdentityNumber { get; set; }

    [Required]
    public DateTime DateOfBirth { get; set; }

    [Required]
    public string Nationality { get; set; }

    [Required]
    public string Password { get; set; }

    [Required]
    public UserDetail UserDetail { get; set; }

    public ICollection<Education> Educations { get; set; }
    public ICollection<Work>? Works { get; set; }
    public ICollection<Language>? Languages { get; set; }
    public ICollection<Certificate>? Certificates { get; set; }
    public ICollection<Course>? Courses { get; set; }
    public ICollection<Skill>? Skills { get; set; }
}
