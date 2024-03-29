﻿using HumanResources.DataAccess.Abstract;
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
            services.AddSingleton<IWorkRepository, WorkRepository>();
            services.AddSingleton<IEducationRepository, EducationRepository>();
            services.AddSingleton<IEducationDegreeRepository, EducationDegreeRepository>();
            services.AddSingleton<IEducationTypeRepository, EducationTypeRepository>();
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<IApplicantCVRepository, ApplicantCVRepository>();
            services.AddSingleton<IUserDetailRepository, UserDetailRepository>();
            services.AddSingleton<IJobRepository, JobRepository>();
            services.AddSingleton<IWorkspaceRepository, WorkspaceRepository>();
            services.AddSingleton<IApplyForJobRepository, ApplyForJobRepository>();
        }
    }
}
