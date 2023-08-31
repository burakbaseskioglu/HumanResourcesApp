namespace HumanResources.Entities.Dto.ApplyForJob
{
    public class ApplyForJobDto
    {
        public Guid Id { get; set; }
        public Guid JobId { get; set; }
        public Guid UserId { get; set; }
        public string CoverLetter { get; set; }
        public string Status { get; set; }
    }
}
