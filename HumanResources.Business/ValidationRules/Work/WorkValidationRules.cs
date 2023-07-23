using FluentValidation;
using HumanResources.Entities.Dto.Work;

namespace HumanResources.Business.ValidationRules.Work
{
    public class WorkInsertValidationRule : AbstractValidator<WorkInsertDto>
    {
        public WorkInsertValidationRule()
        {
            RuleFor(x => x.UserId).NotEmpty().WithMessage("Kullanıcı boş geçilemez");
            RuleFor(x => x.CompanyName).NotEmpty().WithMessage("Firma Adı boş geçilemez");
            RuleFor(x => x.Industry).NotEmpty().WithMessage("Sektör boş geçilemez");
            RuleFor(x => x.HowToWork).NotEmpty().WithMessage("Çalışma Şekli boş geçilemez");
            RuleFor(x => x.StillInThisBusiness).NotEmpty().WithMessage("Halen bu işte çalışıyor musunuz alanı boş geçilemez");
            RuleFor(x => x.StartedDate).NotEmpty().WithMessage("Başlangıç Tarihi boş geçilemez");
            RuleFor(x => x.EndDate).NotEmpty().WithMessage("Bitiş Tarihi boş geçilemez");
            RuleFor(x => x.UnitWorked).NotEmpty().WithMessage("Çalışılan Birim boş geçilemez");
            RuleFor(x => x.Position).NotEmpty().WithMessage("Pozisyon bilgisi boş geçilemez");
            RuleFor(x => x.ShortJobDescription).NotEmpty().WithMessage("Kısa iş tanımı boş geçilemez");

        }
    }

    public class WorkUpdateValidationRule : AbstractValidator<WorkUpdateDto>
    {
        public WorkUpdateValidationRule()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id boş geçilemez");
            RuleFor(x => x.UserId).NotEmpty().WithMessage("Kullanıcı boş geçilemez");
            RuleFor(x => x.CompanyName).NotEmpty().WithMessage("Firma Adı boş geçilemez");
            RuleFor(x => x.Industry).NotEmpty().WithMessage("Sektör boş geçilemez");
            RuleFor(x => x.HowToWork).NotEmpty().WithMessage("Çalışma Şekli boş geçilemez");
            RuleFor(x => x.StillInThisBusiness).NotEmpty().WithMessage("Halen bu işte çalışıyor musunuz alanı boş geçilemez");
            RuleFor(x => x.StartedDate).NotEmpty().WithMessage("Başlangıç Tarihi boş geçilemez");
            RuleFor(x => x.EndDate).NotEmpty().WithMessage("Bitiş Tarihi boş geçilemez");
            RuleFor(x => x.UnitWorked).NotEmpty().WithMessage("Çalışılan Birim boş geçilemez");
            RuleFor(x => x.Position).NotEmpty().WithMessage("Pozisyon bilgisi boş geçilemez");
            RuleFor(x => x.ShortJobDescription).NotEmpty().WithMessage("Kısa iş tanımı boş geçilemez");

        }
    }
}
