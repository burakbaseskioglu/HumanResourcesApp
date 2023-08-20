namespace HumanResources.Entities.Dto.Job
{
    public class JobInsertDto
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime EndDate { get; set; }
        public int WorkType { get; set; }
        public Guid WorkspaceId { get; set; }
    }
}
