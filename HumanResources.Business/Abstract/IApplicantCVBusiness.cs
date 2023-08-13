using HumanResources.Core.Utilities.Result;
using HumanResources.Entities.Concrete;
using HumanResources.Entities.Dto.ApplicantCv;

namespace HumanResources.Business.Abstract
{
    public interface IApplicantCVBusiness
    {
        IDataResult<ApplicantCVDto> Get(Guid userId);
    }
}
