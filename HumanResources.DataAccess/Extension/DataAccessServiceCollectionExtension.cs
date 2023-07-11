using HumanResources.DataAccess.Abstract;
using HumanResources.DataAccess.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace HumanResources.DataAccess.Extension
{
    public static class DataAccessServiceCollectionExtension
    {
        public static void AddDataAccessServices(this IServiceCollection services)
        {
            services.AddSingleton<ILanguageRepository, LanguageRepository>();
            services.AddSingleton<ICourseRepository, CourseRepository>();
            services.AddSingleton<ISkillRepository, SkillRepository>();
            services.AddSingleton<ICertificateRepository, CertificateRepository>();
        }
    }
}
