using HumanResources.Business.Abstract;
using HumanResources.Business.ActionFilter;
using HumanResources.Business.Concrete;
using HumanResources.Core.Utilities.Security.EncryptDecrypt;
using HumanResources.Core.Utilities.Security.Jwt;
using Microsoft.Extensions.DependencyInjection;

namespace HumanResources.Business.Extension
{
    public static class BusinessServiceCollectionExtension
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddSingleton<ILanguageBusiness, LanguageBusiness>();
            services.AddSingleton<ICourseBusiness, CourseBusiness>();
            services.AddSingleton<ISkillBusiness, SkillBusiness>();
            services.AddSingleton<ICertificateBusiness, CertificateBusiness>();
            services.AddSingleton<IWorkBusiness, WorkBusiness>();
            services.AddSingleton<IEducationBusiness, EducationBusiness>();
            services.AddSingleton<IUserBusiness, UserBusiness>();
            services.AddSingleton<IAuthBusiness, AuthBusiness>();
            services.AddSingleton<IApplicantCVBusiness, ApplicantCVBusiness>();
            services.AddScoped<ValidationFilter>();
            services.AddSingleton<IJobBusiness, JobBusiness>();
            services.AddSingleton<IWorkspaceBusiness, WorkspaceBusiness>();
            services.AddSingleton<IApplyForJobBusiness, ApplyForJobBusiness>();
            services.AddSingleton<IEncryption, Encryption>();
            services.AddSingleton<ITokenService, TokenService>();
        }
    }
}
