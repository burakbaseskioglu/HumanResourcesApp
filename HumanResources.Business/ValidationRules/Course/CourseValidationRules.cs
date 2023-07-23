using FluentValidation;
using HumanResources.Entities.Dto.Course;

namespace HumanResources.Business.ValidationRules.Course
{
    public class CourseInsertValidationRule : AbstractValidator<CourseInsertDto>
    {
        public CourseInsertValidationRule()
        {
            RuleFor(x => x.UserId).NotEmpty().WithMessage("Kullanıcı Id boş geçilemez");
            RuleFor(x => x.CourseName).NotEmpty().WithMessage("Kurs adı boş geçilemez");
            RuleFor(x => x.Company).NotEmpty().WithMessage("Kurs şirketi boş geçilemez");
            RuleFor(x => x.StartedDate).NotEmpty().WithMessage("Başlangıç tarihi boş geçilemez");
        }
    }

    public class CourseUpdateValidationRule : AbstractValidator<CourseUpdateDto>
    {
        public CourseUpdateValidationRule()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id boş geçilemez");
            RuleFor(x => x.UserId).NotEmpty().WithMessage("Kullanıcı Id boş geçilemez");
            RuleFor(x => x.CourseName).NotEmpty().WithMessage("Kurs adı boş geçilemez");
            RuleFor(x => x.Company).NotEmpty().WithMessage("Kurs şirketi boş geçilemez");
            RuleFor(x => x.StartedDate).NotEmpty().WithMessage("Başlangıç tarihi boş geçilemez");
        }
    }
}
