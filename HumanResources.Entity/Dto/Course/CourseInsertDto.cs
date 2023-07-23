namespace HumanResources.Entities.Dto.Course
{
    public class CourseInsertDto
    {
        public Guid UserId { get; set; }
        public string CourseName { get; set; }
        public string Company { get; set; }
        public DateTime StartedDate { get; set; }
    }
}
