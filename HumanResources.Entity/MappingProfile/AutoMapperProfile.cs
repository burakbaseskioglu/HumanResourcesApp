using AutoMapper;
using HumanResources.Entities.Concrete;
using HumanResources.Entities.Dto.ApplicantCv;
using HumanResources.Entities.Dto.ApplyForJob;
using HumanResources.Entities.Dto.Auth;
using HumanResources.Entities.Dto.Certificate;
using HumanResources.Entities.Dto.Course;
using HumanResources.Entities.Dto.Education;
using HumanResources.Entities.Dto.Job;
using HumanResources.Entities.Dto.Language;
using HumanResources.Entities.Dto.Skill;
using HumanResources.Entities.Dto.User;
using HumanResources.Entities.Dto.Work;
using HumanResources.Entities.Dto.Workspace;
using HumanResources.Entities.Enums;

namespace HumanResources.Core.MappingProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<LanguageInsertDto, Language>();
            CreateMap<Language, LanguageDto>();
            CreateMap<LanguageUpdateDto, Language>();

            CreateMap<CertificateInsertDto, Certificate>();
            CreateMap<Certificate, CertificateDto>();
            CreateMap<CertificateUpdateDto, Certificate>();

            CreateMap<SkillInsertDto, Skill>();
            CreateMap<Skill, LanguageDto>();
            CreateMap<SkillDto, Skill>();

            CreateMap<CourseInsertDto, Course>();
            CreateMap<Course, CourseDto>();
            CreateMap<CourseUpdateDto, Course>();

            CreateMap<WorkInsertDto, Work>();
            CreateMap<Work, WorkDto>()
                .ForMember(dest => dest.User, opt => opt.MapFrom(src => src.User));
            CreateMap<WorkUpdateDto, Work>();

            CreateMap<Education, EducationDto>()
                .ForMember(dest => dest.EducationDegree, opt => opt.MapFrom(src => src.EducationDegree.Name))
                .ForMember(dest => dest.EducationType, opt => opt.MapFrom(src => src.EducationType.Name))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => Enum.GetName(typeof(EducationStatus), src.EducationStatus)))
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate.ToString("yyy-MM-dd")))
                .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate!.Value.ToString("yyy-MM-dd")));

            CreateMap<EducationInsertDto, Education>();
            CreateMap<EducationUpdateDto, Education>();

            CreateMap<EducationType, EducationTypeDto>();
            CreateMap<EducationDegree, EducationDegreeDto>();

            CreateMap<RegisterDto, User>();
            CreateMap<User, UserDto>();
            CreateMap<UserUpdateDto, User>();
            CreateMap<User, UserIdentityDto>()
                .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.DateOfBirth.ToString("yyyy-MM-dd")));
            CreateMap<User, UserShortInfoDto>();
            CreateMap<ApplicantCV, ApplicantCVDto>();

            CreateMap<UserDetailInsertOrUpdateDto, UserDetail>();
            CreateMap<UserDetail, UserDetailDto>()
                .ForMember(dest => dest.MilitaryServiceStatusDate, opt => opt.MapFrom(src => src.MilitaryServiceStatusDate!.Value.ToString("yyy-MM-dd")))
                .ForMember(dest => dest.MilitaryServiceStatus, opt => opt.MapFrom(src => GetMilitaryServiceStatusDisplayName(src.MilitaryServiceStatus)))
                .ForMember(dest => dest.MaritalStatus, opt => opt.MapFrom(src => Enum.GetName(typeof(MaritalStatus), src.MaritalStatus)));

            CreateMap<JobInsertDto, Job>();
            CreateMap<Job, JobDto>()
                .ForMember(dest => dest.Workspace, opt => opt.MapFrom(src => src.Workspace.Name));
            CreateMap<JobUpdateDto, Job>();

            CreateMap<WorkspaceInsertDto, Workspace>();
            CreateMap<WorkspaceUpdateDto, Workspace>();
            CreateMap<Workspace, WorkspaceDto>();

            CreateMap<ApplyForJobInsertDto, ApplyForJob>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => (int)ApplyForJobStatus.Waiting));
            CreateMap<ApplyForJobUpdateDto, ApplyForJob>();
            CreateMap<ApplyForJob, ApplyForJobDto>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => GetApplyForJobStatusDisplayName(src.Status)));
        }

        public string GetMilitaryServiceStatusDisplayName(int enumId)
        {
            var result = enumId switch
            {
                0 => MilitaryServiceStatus.Terhis.GetDisplayName(),
                1 => MilitaryServiceStatus.Tecil.GetDisplayName(),
                2 => MilitaryServiceStatus.Muaf.GetDisplayName(),
                3 => MilitaryServiceStatus.BedelliYapılacak.GetDisplayName(),
                _ => string.Empty
            };

            return result;
        }

        public string GetApplyForJobStatusDisplayName(int enumId)
        {
            var result = enumId switch
            {
                0 => ApplyForJobStatus.Waiting.GetDisplayName(),
                1 => ApplyForJobStatus.Accepted.GetDisplayName(),
                2 => ApplyForJobStatus.Rejected.GetDisplayName(),
                _ => string.Empty
            };

            return result;
        }
    }
}
