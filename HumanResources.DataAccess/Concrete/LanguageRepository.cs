using HumanResources.Core.DataAccess.Repository.EntityFramework;
using HumanResources.DataAccess.Abstract;
using HumanResources.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HumanResources.DataAccess.Concrete
{
    public class LanguageRepository : EfRepositoryBase<Language, ApplicationDbContext>, ILanguageRepository
    {
    }
}
