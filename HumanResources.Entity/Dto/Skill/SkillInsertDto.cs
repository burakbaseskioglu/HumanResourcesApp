namespace HumanResources.Entities.Dto.Skill
{
    public class SkillInsertDto
    {
        public Guid UserId { get; set; }
        public string SkillName { get; set; }
        public string Level { get; set; }
    }
}
