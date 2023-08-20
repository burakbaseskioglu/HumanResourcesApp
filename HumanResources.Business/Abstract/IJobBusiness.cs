using HumanResources.Core.Utilities.Result;
using HumanResources.Entities.Dto.Job;

namespace HumanResources.Business.Abstract
{
    public interface IJobBusiness
    {
        IResult Insert(JobInsertDto jobInsertDto);
        IResult Update(JobUpdateDto jobUpdateDto);
        IResult Delete(Guid id);
        IDataResult<IEnumerable<JobDto>> GetAll();
    }
}
