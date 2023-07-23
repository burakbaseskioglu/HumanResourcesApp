using FluentValidation;
using HumanResources.Entities.Dto.Language;

namespace HumanResources.Business.ValidationRules.Language
{
    public class LanguageInsertValidationRule : AbstractValidator<LanguageInsertDto>
    {
        public LanguageInsertValidationRule()
        {
            RuleFor(x => x.UserId).NotEmpty().WithMessage("UserId alanı boş geçilemez");
            RuleFor(x => x.LanguageName).NotEmpty().WithMessage("LanguageName alanı boş geçilemez");
            RuleFor(x => x.Level).NotEmpty().WithMessage("Level alanı boş geçilemez");
        }
    }

    public class LanguageUpdateValidationRule : AbstractValidator<LanguageUpdateDto>
    {
        public LanguageUpdateValidationRule()
        {
            RuleFor(x => x.UserId).NotEmpty().WithMessage("UserId alanı boş geçilemez");
            RuleFor(x => x.LanguageName).NotEmpty().WithMessage("LanguageName alanı boş geçilemez");
            RuleFor(x => x.Level).NotEmpty().WithMessage("Level alanı boş geçilemez");
        }
    }
}
