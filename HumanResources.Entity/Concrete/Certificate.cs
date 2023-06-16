using HumanResources.Core;

namespace HumanResources.Entities.Concrete
{
    public class Certificate : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string CertificateName { get; set; }
        public string Points { get; set; }
        public DateTime ValidityDate { get; set; }

    }
}
