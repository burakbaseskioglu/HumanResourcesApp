namespace HumanResources.Entities.Dto.Certificate
{
    public class CertificateDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string CertificateName { get; set; }
        public string Points { get; set; }
        public DateTime ValidityDate { get; set; }
    }
}
