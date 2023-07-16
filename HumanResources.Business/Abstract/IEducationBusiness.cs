using HumanResources.Core.Utilities.Result;
using HumanResources.Entities.Dto.Education;

namespace HumanResources.Business.Abstract
{
    public interface IEducationBusiness
    {
        IResult Add(EducationInsertDto educationInsertDto);
        IDataResult<IEnumerable<EducationDto>> GetAll();
        IResult Delete(Guid workId);
        IResult Update(EducationUpdateDto educationUpdateDto);
        IDataResult<IEnumerable<EducationTypeDto>> GetAllEducationType();
        IDataResult<IEnumerable<EducationDegreeDto>> GetAllEducationDegree();
        IDataResult<IEnumerable<EducationDto>> GetEducationsByUserId(Guid id);
    }
}
