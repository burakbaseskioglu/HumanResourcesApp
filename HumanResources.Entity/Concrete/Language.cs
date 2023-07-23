using HumanResources.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace HumanResources.Entities.Concrete
{
    public class Language : BaseEntity
    {
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        public string LanguageName { get; set; }

        [Required]
        public string Level { get; set; }
    }
}
