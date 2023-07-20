using AutoMapper;
using HumanResources.Entities.Concrete;
using HumanResources.Entities.Dto.Certificate;
using HumanResources.Entities.Dto.Course;
using HumanResources.Entities.Dto.Education;
using HumanResources.Entities.Dto.Language;
using HumanResources.Entities.Dto.Skill;
using HumanResources.Entities.Dto.User;
using HumanResources.Entities.Dto.Work;
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

            CreateMap<User, UserShortInfoDto>();

            CreateMap<WorkInsertDto, Work>();
            CreateMap<Work, WorkDto>()
                .ForMember(dest => dest.User, opt => opt.MapFrom(src => src.User));
            CreateMap<WorkUpdateDto, Work>();

            CreateMap<Education, EducationDto>()
                .ForMember(dest => dest.EducationDegree, opt => opt.MapFrom(src => src.EducationDegree.Name))
                .ForMember(dest => dest.EducationType, opt => opt.MapFrom(src => src.EducationType.Name))
                .ForMember(dest=>dest.Status, opt=>opt.MapFrom(src=>Enum.GetName(typeof(EducationStatus), src.EducationStatus)));

            CreateMap<EducationInsertDto, Education>();
            CreateMap<EducationUpdateDto, Education>();

            CreateMap<EducationType, EducationTypeDto>();
            CreateMap<EducationDegree, EducationDegreeDto>();
        }
    }
}
