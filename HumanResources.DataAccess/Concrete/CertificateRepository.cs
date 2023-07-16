using HumanResources.DataAccess.Abstract;
using HumanResources.DataAccess.Repository.EntityFramework;
using HumanResources.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HumanResources.DataAccess.Concrete
{
    public class CertificateRepository : EfRepositoryBase<Certificate>, ICertificateRepository
    {
        private readonly IConfiguration _configuration;

        public CertificateRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        public List<Certificate> GetAllCertificatesWithUserInfo()
        {
            using (ApplicationDbContext context = new(_configuration))
            {
                return context.Certificates.Include(x => x.User).ToList();
            }
        }
    }
}
