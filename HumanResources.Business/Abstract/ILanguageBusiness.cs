using HumanResources.Entities;

namespace HumanResources.Business.Abstract
{
    public interface ILanguageBusiness
    {
        void Add(LanguageInsertDto languageInsertDto);
        IEnumerable<LanguageDto> GetAll();
    }
}
