using AutoMapper;
using HumanResources.Entities.Concrete;
using HumanResources.Entities.Dto.Certificate;
using HumanResources.Entities.Dto.Course;
using HumanResources.Entities.Dto.Language;
using HumanResources.Entities.Dto.Skill;
using HumanResources.Entities.Dto.Work;

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
            CreateMap<Work, WorkDto>();
            CreateMap<WorkUpdateDto, Work>();
        }
    }
}
