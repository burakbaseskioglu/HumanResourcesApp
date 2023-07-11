using HumanResources.DataAccess.Abstract;
using HumanResources.DataAccess.Repository.EntityFramework;
using HumanResources.Entities.Concrete;
using Microsoft.Extensions.Configuration;

namespace HumanResources.DataAccess.Concrete
{
    public class CertificateRepository : EfRepositoryBase<Certificate>, ICertificateRepository
    {
        public CertificateRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
