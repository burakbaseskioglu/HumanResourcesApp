using HumanResources.DataAccess.Repository;
using HumanResources.Entities.Concrete;
using HumanResources.Entities.Dto.ApplicantCv;

namespace HumanResources.DataAccess.Abstract
{
    public interface IApplicantCVRepository : IRepository<ApplicantCV>
    {
        ApplicantCV GetCV(Guid id);
    }
}
