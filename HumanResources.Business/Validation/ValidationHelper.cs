using FluentValidation;
using FluentValidation.Results;

namespace HumanResources.Business.Validation
{
    public static class ValidationHelper
    {
        public static ValidationResult Validate(Type type, object[] objects)
        {
            //IsAssignableFrom(Type type) : Belirtilen türün, geçerli type nesnesi tarafından temsil edilen türe atanıp atanamayacağını gösterir.
            //Activator.CreateInstance(type) metodu ile type nesnesinin örneğini oluşturuyoruz. Ardından IValidator tipine cast ediyoruz.

            //CanValidateInstancesOfType(item.GetType()) : Belirtilen türün geçerli nesne türü tarafından doğrulanıp doğrulanamayacağını gösterir.
            //True ise belirtilen türün nesneleri doğrulanabilir demektir.

            if (!typeof(IValidator).IsAssignableFrom(type))
            {
                throw new Exception("");
            }

            var validator = (IValidator)Activator.CreateInstance(type);
            ValidationResult result = new ValidationResult();

            foreach (var item in objects)
            {
                
                if (validator.CanValidateInstancesOfType(item.GetType()))
                {
                    result = validator.Validate(new ValidationContext<object>(item));
                    if (!result.IsValid)
                    {
                        return result;
                    }
                }
            }

            return result;
        }
    }
}
