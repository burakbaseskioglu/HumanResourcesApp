using HumanResources.Entities.Dto.Certificate;
using HumanResources.Entities.Dto.Course;
using HumanResources.Entities.Dto.Education;
using HumanResources.Entities.Dto.Language;
using HumanResources.Entities.Dto.Skill;
using HumanResources.Entities.Dto.User;
using HumanResources.Entities.Dto.Work;

namespace HumanResources.Entities.Dto.ApplicantCv
{
    public class ApplicantCVDto
    {
        public UserDto User { get; set; }
        public UserDetailDto UserDetail { get; set; }
        public IEnumerable<EducationDto> Educations { get; set; }
        public IEnumerable<WorkDto> Works { get; set; }
        public IEnumerable<LanguageDto> Languages { get; set; }
        public IEnumerable<CourseDto> Courses { get; set; }
        public IEnumerable<SkillDto> Skills { get; set; }
        public IEnumerable<CertificateDto> Certificates { get; set; }
    }
}
