using FluentValidation;
using HumanResources.Entities.Dto.User;
using System.Text.RegularExpressions;

namespace HumanResources.Business.ValidationRules.User
{
    public class UserUpdateValidationRule : AbstractValidator<UserUpdateDto>
    {
        public UserUpdateValidationRule()
        {
            RuleFor(x => x.Email).NotEmpty().NotNull().WithMessage("Email Adresi boş geçilemez.")
                .Must(IsValidEmail).WithMessage("Geçerli bir email adresi giriniz.")
                .MinimumLength(3).WithMessage("En az 3 karakter girmelisiniz.")
                .MaximumLength(128).WithMessage("En fazla 128 karakter girebilirsiniz.");

            RuleFor(x => x.Phone).NotEmpty().NotNull().WithMessage("Telefon alanı boş geçilemez.")
                .Must(IsValidPhoneNumber).WithMessage("Geçerli bir telefon numarası giriniz.");
        }

        public bool IsValidPhoneNumber(string phoneNumber)
        {
            var result = Regex.Match(phoneNumber, @"^5\d{9}$");

            if (result.Success)
            {
                return true;
            }

            return false;
        }

        public bool IsValidEmail(string emailAddress)
        {
            var result = Regex.Match(emailAddress, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

            if (result.Success)
            {
                return true;
            }

            return false;
        }
    }

    public class UserDetailInsertOrUpdateValidationRule : AbstractValidator<UserDetailInsertOrUpdateDto>
    {
        public UserDetailInsertOrUpdateValidationRule()
        {
            RuleFor(x => x.UserId)
                .NotEmpty().NotNull().WithMessage("User Id Adresi boş geçilemez.");

            RuleFor(x => x.Gender)
                .NotEmpty().NotNull().WithMessage("Cinsiyet alanı boş geçilemez.");

            RuleFor(x => x.PlaceOfBirth)
                .NotEmpty().NotNull().WithMessage("Doğum Yeri boş geçilemez.")
                .MinimumLength(3).WithMessage("En az 3 karakter girmelisiniz.")
                .MaximumLength(24).WithMessage("En fazla 24 karakter girebilirsiniz.");

            RuleFor(x => x.Address)
                .NotEmpty().NotNull().WithMessage("Adres boş geçilemez.")
                .MinimumLength(3).WithMessage("En az 3 karakter girmelisiniz.")
                .MaximumLength(200).WithMessage("En fazla 200 karakter girebilirsiniz.");

            RuleFor(x => x.MilitaryServiceStatus)
                .NotEmpty().NotNull().WithMessage("Askerlik Durumu boş geçilemez.");

            RuleFor(x => x.BloodType)
                .NotEmpty().NotNull().WithMessage("Kan Türü boş geçilemez.")
                .MinimumLength(3).WithMessage("En az 3 karakter girmelisiniz.")
                .MaximumLength(10).WithMessage("En fazla 10 karakter girebilirsiniz.");

            RuleFor(x => x.DrivingLicense)
                .MaximumLength(10).WithMessage("Sürücü Belgesi alanı maksimum 10 karakter olabilir.");
        }
    }
}
