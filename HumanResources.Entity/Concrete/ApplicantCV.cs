using HumanResources.Entities.Abstract;
using HumanResources.Entities.Dto.Certificate;
using HumanResources.Entities.Dto.Course;
using HumanResources.Entities.Dto.Education;
using HumanResources.Entities.Dto.Language;
using HumanResources.Entities.Dto.Skill;
using HumanResources.Entities.Dto.User;
using HumanResources.Entities.Dto.Work;

namespace HumanResources.Entities.Concrete
{
    public class ApplicantCV : BaseEntity
    {
        public User User { get; set; }
        public UserDetail UserDetail { get; set; }
        public IEnumerable<Education> Educations { get; set; }
        public IEnumerable<Work> Works { get; set; }
        public IEnumerable<Language> Languages { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
        public IEnumerable<Certificate> Certificates { get; set; }
    }
}
