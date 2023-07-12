using HumanResources.Core.Utilities.Result;
using HumanResources.Entities.Dto.Skill;

namespace HumanResources.Business.Abstract
{
    public interface ISkillBusiness
    {
        IResult Add(SkillInsertDto skillInsertDto);
        IDataResult<IEnumerable<SkillDto>> GetAll();
        IResult Delete(Guid skillId);
        IResult Update(SkillUpdateDto skillUpdateDto);
    }
}
