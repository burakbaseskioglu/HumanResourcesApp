using HumanResources.DataAccess.Repository;
using HumanResources.Entities.Concrete;

namespace HumanResources.DataAccess.Abstract
{
    public interface ILanguageRepository : IRepository<Language>
    {
        List<Language> GetAllLanguagesWithUserInfo();
    }
}
