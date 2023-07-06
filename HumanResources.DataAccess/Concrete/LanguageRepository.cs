using HumanResources.DataAccess.Abstract;
using HumanResources.DataAccess.Repository.EntityFramework;
using HumanResources.Entities.Concrete;
using Microsoft.Extensions.Configuration;

namespace HumanResources.DataAccess.Concrete
{
    public class LanguageRepository : EfRepositoryBase<Language>, ILanguageRepository
    {
        public LanguageRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
