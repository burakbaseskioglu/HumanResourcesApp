namespace HumanResources.Entities.Dto.Skill
{
    public class SkillUpdateDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string SkillName { get; set; }
        public string Level { get; set; }
    }
}
