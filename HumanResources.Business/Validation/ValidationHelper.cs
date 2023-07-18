using FluentValidation;
using FluentValidation.Results;

namespace HumanResources.Business.Validation
{
    public static class ValidationHelper
    {
        public static ValidationResult Validate(Type type, object[] validationObjects)
        {
            //IsAssignableFrom(Type type) : Belirtilen türün, geçerli type nesnesi tarafından temsil edilen türe atanıp atanamayacağını gösterir.
            //Activator.CreateInstance(type) metodu ile type nesnesinin örneğini oluşturuyoruz. Ardından IValidator tipine cast ediyoruz.

            //CanValidateInstancesOfType(item.GetType()) : Belirtilen türün geçerli nesne türü tarafından doğrulanıp doğrulanamayacağını gösterir.
            //True ise belirtilen türün nesneleri doğrulanabilir demektir.

            if (!typeof(IValidator).IsAssignableFrom(type))
            {
                throw new Exception("Bu geçerli bir doğrulama sınıfı değil.");
            }

            var validator = (IValidator)Activator.CreateInstance(type)!;
            var validationResult = new ValidationResult();

            foreach (var item in validationObjects)
            {
                if (validator.CanValidateInstancesOfType(item.GetType()))
                {
                    validationResult = validator.Validate(new ValidationContext<object>(item));
                    if (!validationResult.IsValid)
                    {
                        return validationResult;
                    }
                }
            }

            return validationResult;
        }
    }
}
