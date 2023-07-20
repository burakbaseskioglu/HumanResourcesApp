using HumanResources.Entities.Dto.User;

namespace HumanResources.Entities.Dto.Education
{
    public class EducationDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public UserShortInfoDto User { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int EducationStatus { get; set; }
        public string Faculty { get; set; }
        public string GraduationDegree { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public Guid EducationTypeId { get; set; }
        public string EducationType { get; set; }
        public Guid EducationDegreeId { get; set; }
        public string EducationDegree { get; set; }
    }
}
