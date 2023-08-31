using FluentValidation;
using HumanResources.Entities.Dto.Workspace;

namespace HumanResources.Business.ValidationRules.Workspace
{
    public class WorkspaceInsertValidationRules : AbstractValidator<WorkspaceInsertDto>
    {
        public WorkspaceInsertValidationRules()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("İş Alanı adı boş geçilemez")
                .MinimumLength(3).MaximumLength(60).WithMessage("İş Alanı adı en az 3, en fazla 60 karakter olabilir.");
        }
    }

    public class WorkspaceUpdateValidationRules : AbstractValidator<WorkspaceUpdateDto>
    {
        public WorkspaceUpdateValidationRules()
        {
            RuleFor(x => x.Id).NotNull().NotEmpty().WithMessage("Id alanı boş geçilemez");

            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("İş Alanı adı boş geçilemez")
                .MinimumLength(3).MaximumLength(60).WithMessage("İş Alanı adı en az 3, en fazla 60 karakter olabilir.");
        }
    }
}
