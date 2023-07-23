using FluentValidation;
using HumanResources.Entities.Dto.Certificate;

namespace HumanResources.Business.ValidationRules.Certificate
{
    public class CertificateInsertValidationRule : AbstractValidator<CertificateInsertDto>
    {
        public CertificateInsertValidationRule()
        {
            RuleFor(x => x.CertificateName).NotEmpty().NotNull().WithMessage("Sertifika adı boş geçilemez");
            RuleFor(x => x.Points).NotEmpty().NotNull().WithMessage("Puan boş geçilemez");
            RuleFor(x => x.ValidityDate).NotEmpty().NotNull().WithMessage("Geçerlilik tarihi boş geçilemez");
        }
    }

    public class CertificateUpdateValidationRule : AbstractValidator<CertificateUpdateDto>
    {
        public CertificateUpdateValidationRule()
        {
            RuleFor(x => x.Id).NotEmpty().NotNull().WithMessage("Id boş geçilemez");
            RuleFor(x => x.UserId).NotEmpty().NotNull().WithMessage("Kullanıcı boş geçilemez");
            RuleFor(x => x.CertificateName).NotEmpty().NotNull().WithMessage("Sertifika adı boş geçilemez");
            RuleFor(x => x.Points).NotEmpty().NotNull().WithMessage("Puan boş geçilemez");
            RuleFor(x => x.ValidityDate).NotEmpty().NotNull().WithMessage("Geçerlilik tarihi boş geçilemez");
        }
    }
}
