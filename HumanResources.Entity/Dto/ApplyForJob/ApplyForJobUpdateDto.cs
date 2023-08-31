namespace HumanResources.Entities.Dto.ApplyForJob
{
    public class ApplyForJobUpdateDto
    {
        public Guid Id { get; set; }
        public Guid JobId { get; set; }
        public Guid UserId { get; set; }
        public string CoverLetter { get; set; }
        public int Status { get; set; }
    }
}
