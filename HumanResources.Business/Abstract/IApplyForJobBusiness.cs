using HumanResources.Core.Utilities.Result;
using HumanResources.Entities.Dto.ApplyForJob;

namespace HumanResources.Business.Abstract
{
    public interface IApplyForJobBusiness
    {
        IResult Insert(ApplyForJobInsertDto applyForJobInsertDto);
        IResult Update(ApplyForJobUpdateDto applyForJobUpdateDto);
        IResult Delete(Guid id);
        IDataResult<List<ApplyForJobDto>> GetAll();
        IDataResult<ApplyForJobDto> GetById(Guid id);
    }
}
