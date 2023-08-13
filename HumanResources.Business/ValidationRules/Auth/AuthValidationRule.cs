using FluentValidation;
using HumanResources.Entities.Dto.Auth;
using System.Text.RegularExpressions;

namespace HumanResources.Business.ValidationRules.Auth
{
    public class RegisterValidationRule : AbstractValidator<RegisterDto>
    {
        public RegisterValidationRule()
        {
            RuleFor(x => x.Firstname).NotEmpty().NotNull().WithMessage("Ad alanı boş geçilemez.")
                .MinimumLength(3).WithMessage("En az 3 karakter girmelisiniz.")
                .MaximumLength(128).WithMessage("En fazla 128 karakter girebilirsiniz.");

            RuleFor(x => x.Lastname).NotEmpty().NotNull().WithMessage("Soyad alanı boş geçilemez.")
                .MinimumLength(3).WithMessage("En az 3 karakter girmelisiniz.")
                .MaximumLength(128).WithMessage("En fazla 128 karakter girebilirsiniz.");

            RuleFor(x => x.Email).NotEmpty().NotNull().WithMessage("Email Adresi boş geçilemez.")
                .Must(IsValidEmail).WithMessage("Geçerli bir email adresi giriniz.")
                .MinimumLength(3).WithMessage("En az 3 karakter girmelisiniz.")
                .MaximumLength(128).WithMessage("En fazla 128 karakter girebilirsiniz.");

            RuleFor(x => x.Phone).NotEmpty().NotNull().WithMessage("Telefon alanı boş geçilemez.")
                .Must(IsValidPhoneNumber).WithMessage("Geçerli bir telefon numarası giriniz.");

            RuleFor(x => x.IdentityNumber).NotEmpty().NotNull().WithMessage("TC Kimlik Numarası boş geçilemez.")
               .Must(IsValidIdentityNumber).WithMessage("Geçerli bir TC Kimlik Numarası giriniz.");

            RuleFor(x => x.DateOfBirth).NotEmpty().NotNull().WithMessage("Doğum Tarihi boş geçilemez.");

            RuleFor(x => x.Nationality).NotEmpty().NotNull().WithMessage("Uyruk alanı boş geçilemez.")
                .MinimumLength(3).WithMessage("En az 3 karakter girmelisiniz.")
                .MaximumLength(128).WithMessage("En fazla 128 karakter girebilirsiniz.");

            RuleFor(x => x.Password).NotEmpty().NotNull().WithMessage("Şifre alanı boş geçilemez.")
               .MinimumLength(3).WithMessage("En az 3 karakter girmelisiniz.")
               .MaximumLength(128).WithMessage("En fazla 128 karakter girebilirsiniz.")
               .Must(IsValidPassword).WithMessage("Parolanız, \nEn az bir büyük harf (A-Z) içermeli, \nEn az bir küçük harf (a-z) içermeli, " +
               "\nEn az bir sayısal karakter (0-9) içermeli, \nEn az bir özel karakter (alfanumerik olmayan) içermeli");

            RuleFor(x => x.PasswordAgain).NotEmpty().NotNull().WithMessage("Şifre tekrarı boş geçilemez.")
               .MinimumLength(8).WithMessage("En az 8 karakter girmelisiniz.")
               .MaximumLength(32).WithMessage("En fazla 32 karakter girebilirsiniz.")
               .Must(IsValidPassword).WithMessage("Parolanız, \nEn az bir büyük harf (A-Z) içermeli, \nEn az bir küçük harf (a-z) içermeli, " +
               "\nEn az bir sayısal karakter (0-9) içermeli, \nEn az bir özel karakter (alfanumerik olmayan) içermeli");
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

        public bool IsValidIdentityNumber(long identityNumber)
        {
            var result = Regex.Match(identityNumber.ToString(), @"^[1-9]\d{10}$");

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

        public bool IsValidPassword(string password)
        {
            var result = Regex.Match(password, @"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[^A-Za-z0-9]).*$");

            if (result.Success)
            {
                return true;
            }

            return false;
        }
    }

    public class LoginValidationRule : AbstractValidator<LoginDto>
    {
        public LoginValidationRule()
        {
            RuleFor(x => x.Email).NotEmpty().NotNull().WithMessage("Email Adresi boş geçilemez.")
                .Must(IsValidEmail).WithMessage("Geçerli bir email adresi giriniz.")
                .MinimumLength(3).WithMessage("En az 3 karakter girmelisiniz.")
                .MaximumLength(128).WithMessage("En fazla 128 karakter girebilirsiniz.");

            RuleFor(x => x.Password).NotEmpty().NotNull().WithMessage("Şifre alanı boş geçilemez.")
                .MinimumLength(8).WithMessage("En az 8 karakter girmelisiniz.")
               .MaximumLength(32).WithMessage("En fazla 32 karakter girebilirsiniz.");         
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
}
