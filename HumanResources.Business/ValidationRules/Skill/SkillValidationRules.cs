using FluentValidation;
using HumanResources.Entities.Dto.Skill;

namespace HumanResources.Business.ValidationRules.Skill
{
    public class SkillInsertValidationRule : AbstractValidator<SkillInsertDto>
    {
        public SkillInsertValidationRule()
        {
            RuleFor(x => x.UserId).NotEmpty().WithMessage("Kullanıcı boş geçilemez.");
            RuleFor(x => x.SkillName).NotEmpty().WithMessage("Beceri adı boş geçilemez.");
            RuleFor(x => x.Level).NotEmpty().WithMessage("Seviye boş geçilemez.");
        }
    }

    public class SkillUpdateValidationRule : AbstractValidator<SkillUpdateDto>
    {
        public SkillUpdateValidationRule()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id boş geçilemez.");
            RuleFor(x => x.UserId).NotEmpty().WithMessage("Kullanıcı boş geçilemez.");
            RuleFor(x => x.SkillName).NotEmpty().WithMessage("Beceri adı boş geçilemez.");
            RuleFor(x => x.Level).NotEmpty().WithMessage("Seviye boş geçilemez.");
        }
    }
}
