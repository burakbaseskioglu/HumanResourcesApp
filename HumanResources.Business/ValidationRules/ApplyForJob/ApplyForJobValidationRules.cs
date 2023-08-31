using FluentValidation;
using HumanResources.Entities.Dto.ApplyForJob;

namespace HumanResources.Business.ValidationRules.ApplyForJob
{
    public class ApplyForJobInsertValidationRule : AbstractValidator<ApplyForJobInsertDto>
    {
        public ApplyForJobInsertValidationRule()
        {
            RuleFor(x => x.JobId).NotEmpty().NotNull().WithMessage("İş ilanı seçimi yapılmalıdır.");

            RuleFor(x => x.UserId).NotEmpty().NotNull().WithMessage("Kullanıcı boş geçilemez.");

            RuleFor(x => x.CoverLetter).NotEmpty().NotEmpty().WithMessage("Ön yazı boş geçilemez.")
                .Must(CheckStringType.IsValidString).WithMessage("Ön yazı karakter dizesi olmalıdır.");
        }
    }

    public class ApplyForJobUpdateValidationRule : AbstractValidator<ApplyForJobUpdateDto>
    {
        public ApplyForJobUpdateValidationRule()
        {
            RuleFor(x => x.JobId).NotEmpty().NotNull().WithMessage("İş ilanı seçimi yapılmalıdır.");

            RuleFor(x => x.UserId).NotEmpty().NotNull().WithMessage("Kullanıcı boş geçilemez.");

            RuleFor(x => x.CoverLetter).NotEmpty().NotEmpty().WithMessage("Ön yazı boş geçilemez.")
                .Must(CheckStringType.IsValidString).WithMessage("Ön yazı karakter dizesi olmalıdır.");

            RuleFor(x => x.Status).NotEmpty().NotEmpty().WithMessage("İş Başvurusu Durumu boş geçilemez.");
        }
    }

    public static class CheckStringType
    {
        public static bool IsValidString(string value)
        {
            if (typeof(string) != value.GetType())
            {
                return false;
            }

            return true;
        }
    }
}
