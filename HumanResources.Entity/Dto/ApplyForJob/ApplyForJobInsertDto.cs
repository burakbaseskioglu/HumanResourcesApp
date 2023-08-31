namespace HumanResources.Entities.Dto.ApplyForJob
{
    public class ApplyForJobInsertDto
    {
        public Guid JobId { get; set; }
        public Guid UserId { get; set; }
        public string CoverLetter { get; set; }
    }
}
