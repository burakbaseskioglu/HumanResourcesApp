using HumanResources.DataAccess.Abstract;
using HumanResources.DataAccess.Repository.EntityFramework;
using HumanResources.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HumanResources.DataAccess.Concrete
{
    public class LanguageRepository : EfRepositoryBase<Language>, ILanguageRepository
    {
        private readonly IConfiguration _configuration;

        public LanguageRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        public List<Language> GetAllLanguagesWithUserInfo()
        {
            using (ApplicationDbContext context = new(_configuration))
            {
                return context.Languages.Include(x => x.User).ToList();
            }
        }
    }
}
