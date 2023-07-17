using FluentValidation;
using HumanResources.Entities.Dto.Education;

namespace HumanResources.Business
{
    public class ValidationRule:AbstractValidator<EducationInsertDto>
    {
        public ValidationRule()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("Üniversite adı boş geçilemez.");
            RuleFor(x => x.Department).NotEmpty().NotNull().WithMessage("Bölüm boş geçilemez.");
        }
    }
}
