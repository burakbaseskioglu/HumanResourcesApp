namespace HumanResources.Entities.Dto.Language
{
    public class LanguageInsertDto
    {
        public Guid UserId { get; set; }
        public string LanguageName { get; set; }
        public string Level { get; set; }
    }
}
