using HumanResources.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace HumanResources.Entities.Concrete
{
    public class Certificate : BaseEntity
    {
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        public string CertificateName { get; set; }

        public string? Points { get; set; }

        [Required]
        public DateTime ValidityDate { get; set; }

    }
}
