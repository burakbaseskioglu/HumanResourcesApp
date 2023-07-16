using HumanResources.DataAccess.Repository;
using HumanResources.Entities.Concrete;

namespace HumanResources.DataAccess.Abstract
{
    public interface ICertificateRepository : IRepository<Certificate>
    {
        List<Certificate> GetAllCertificatesWithUserInfo();
    }
}
