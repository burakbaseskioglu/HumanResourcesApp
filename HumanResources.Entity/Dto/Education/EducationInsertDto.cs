namespace HumanResources.Entities.Dto.Education
{
    public class EducationInsertDto
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int EducationStatus { get; set; }
        public string Faculty { get; set; }
        public string GraduationDegree { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public Guid EducationTypeId { get; set; }
        public Guid EducationDegreeId { get; set; }
    }
}
