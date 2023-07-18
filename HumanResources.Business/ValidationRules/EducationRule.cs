using FluentValidation;
using HumanResources.Entities.Dto.Education;

namespace HumanResources.Business.ValidationRules
{
    public class EducationInsertRule : AbstractValidator<EducationInsertDto>
    {
        public EducationInsertRule()
        {
            RuleFor(x => x.UserId).NotEmpty().NotNull().WithMessage("Kullanıcı boş geçilemez.");
            RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("Üniversite Adı boş geçilemez.");
            RuleFor(x => x.Department).NotEmpty().NotNull().WithMessage("Bölüm boş geçilemez.");
            RuleFor(x => x.EducationStatus).NotEmpty().NotNull().WithMessage("Öğrenim Durumu boş geçilemez.");
            RuleFor(x => x.Faculty).NotEmpty().NotNull().WithMessage("Fakülte Adı boş geçilemez.");
            RuleFor(x => x.GraduationDegree).NotEmpty().NotNull().WithMessage("Diploma Notu boş geçilemez.");
            RuleFor(x => x.StartDate).NotEmpty().NotNull().WithMessage("Başlangıç Tarihi boş geçilemez.");
            RuleFor(x => x.EducationTypeId).NotEmpty().NotNull().WithMessage("Öğrenim Tipi geçilemez.");
            RuleFor(x => x.EducationDegreeId).NotEmpty().NotNull().WithMessage("Öğrenim Türü geçilemez.");
        }
    }

    public class EducationUpdateRule : AbstractValidator<EducationUpdateDto>
    {
        public EducationUpdateRule()
        {
            RuleFor(x => x.UserId).NotEmpty().NotNull().WithMessage("Kullanıcı boş geçilemez.");
            RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("Üniversite Adı boş geçilemez.");
            RuleFor(x => x.Department).NotEmpty().NotNull().WithMessage("Bölüm boş geçilemez.");
            RuleFor(x => x.EducationStatus).NotEmpty().NotNull().WithMessage("Öğrenim Durumu boş geçilemez.");
            RuleFor(x => x.Faculty).NotEmpty().NotNull().WithMessage("Fakülte Adı boş geçilemez.");
            RuleFor(x => x.GraduationDegree).NotEmpty().NotNull().WithMessage("Diploma Notu boş geçilemez.");
            RuleFor(x => x.StartDate).NotEmpty().NotNull().WithMessage("Başlangıç Tarihi boş geçilemez.");
            RuleFor(x => x.EducationTypeId).NotEmpty().NotNull().WithMessage("Öğrenim Tipi geçilemez.");
            RuleFor(x => x.EducationDegreeId).NotEmpty().NotNull().WithMessage("Öğrenim Türü geçilemez.");
        }
    }
}
