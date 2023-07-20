using HumanResources.Core.Utilities.Result;
using HumanResources.Entities.Dto.Language;

namespace HumanResources.Business.Abstract
{
    public interface ILanguageBusiness
    {
        IResult Add(LanguageInsertDto languageInsertDto);
        IDataResult<IEnumerable<LanguageDto>> GetAll();
        IDataResult<IEnumerable<LanguageDto>> GetAllLanguagesByUser(Guid userId);
        IResult Delete(Guid languageId);
        IResult Update(LanguageUpdateDto languageUpdateDto);
    }
}
