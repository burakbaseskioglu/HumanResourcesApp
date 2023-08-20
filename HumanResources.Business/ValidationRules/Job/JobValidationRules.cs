using FluentValidation;
using HumanResources.Entities.Dto.Job;

namespace HumanResources.Business.ValidationRules.Job
{
    public class JobInsertValidationRule : AbstractValidator<JobInsertDto>
    {
        public JobInsertValidationRule()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş geçilemez.")
                .MinimumLength(3).MaximumLength(100).WithMessage("Başlık en az 3, en fazla 100 karakter olabilir.");

            RuleFor(x => x.ShortDescription).NotEmpty().WithMessage("Kısa Açıklama boş geçilemez.")
                .MinimumLength(3).MaximumLength(200).WithMessage("Kısa Açıklama en az 3, en fazla 200 karakter olabilir.");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş geçilemez.")
                .MinimumLength(3).MaximumLength(600).WithMessage("Açıklama en az 3, en fazla 500 karakter olabilir.");

            RuleFor(x => x.Location).NotEmpty().WithMessage("Lokasyon boş geçilemez.")
                .MinimumLength(3).MaximumLength(40).WithMessage("Başlık en az 3, en fazla 40 karakter olabilir.");

            RuleFor(x => x.EndDate).NotEmpty().WithMessage("Bitiş Tarihi boş geçilemez.");

            RuleFor(x => x.WorkType).NotEmpty().WithMessage("Çalışma Tipi boş geçilemez.");

            RuleFor(x => x.WorkspaceId).NotEmpty().WithMessage("Çalışma Alanı boş geçilemez.");
        }
    }

    public class JobUpdateValidationRule : AbstractValidator<JobUpdateDto>
    {
        public JobUpdateValidationRule()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id Alanı boş geçilemez.");

            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş geçilemez.")
                .MinimumLength(3).MaximumLength(100).WithMessage("Başlık en az 3, en fazla 100 karakter olabilir.");

            RuleFor(x => x.ShortDescription).NotEmpty().WithMessage("Kısa Açıklama boş geçilemez.")
                    .MinimumLength(3).MaximumLength(200).WithMessage("Kısa Açıklama en az 3, en fazla 200 karakter olabilir.");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş geçilemez.")
                    .MinimumLength(3).MaximumLength(600).WithMessage("Açıklama en az 3, en fazla 500 karakter olabilir.");

            RuleFor(x => x.Location).NotEmpty().WithMessage("Lokasyon boş geçilemez.")
                    .MinimumLength(3).MaximumLength(40).WithMessage("Başlık en az 3, en fazla 40 karakter olabilir.");

            RuleFor(x => x.EndDate).NotEmpty().WithMessage("Bitiş Tarihi boş geçilemez.");

            RuleFor(x => x.WorkType).NotEmpty().WithMessage("Çalışma Tipi boş geçilemez.");

            RuleFor(x => x.WorkspaceId).NotEmpty().WithMessage("Çalışma Alanı boş geçilemez.");
        }
    }
}
