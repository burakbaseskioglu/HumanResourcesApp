namespace HumanResources.Entities.Dto.Language
{
    public class LanguageDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string LanguageName { get; set; }
        public string Level { get; set; }
    }
}
