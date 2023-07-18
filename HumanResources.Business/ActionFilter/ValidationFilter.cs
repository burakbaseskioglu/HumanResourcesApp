
using HumanResources.Business.Attributes;
using HumanResources.Business.Validation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace HumanResources.Business.ActionFilter
{
    public class ValidationFilter : ActionFilterAttribute
    {
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            //ConstructorArguments : Bu özniteliğe uygulanan argümanların koleksiyonunu alır.

            var arguments = ((ControllerActionDescriptor)context.ActionDescriptor).MethodInfo.CustomAttributes
                .FirstOrDefault(filter => filter.AttributeType == typeof(ValidationAttribute))?.ConstructorArguments;

            var validationType = (Type)arguments[0].Value!;
            var validationObjects = context.ActionArguments.Values.ToArray();
            var validationResult = ValidationHelper.Validate(validationType, validationObjects);

            if (!validationResult.IsValid)
            {
                var validationErrors = validationResult.Errors.Select(error => error.ErrorMessage).ToList();

                context.Result = new ObjectResult(context.ModelState)
                {
                    Value = validationErrors,
                    StatusCode = 400
                };

                return;
            }

            await next();
        }

        public bool HasValidationAttribute(FilterContext filterContext)
        {
            //ControllerActionDescriptor : Bir denetleyici eyleminin açıklamasını temsil eder.
            //MethodInfo : Bir yöntemin açıklamasını temsil eder.
            //CustomAttributes : Bu yönteme uygulanan öznitelikleri alır.
            //filter.AttributeType == typeof(ValidationAttribute) : filter değişkeninin AttributeType özelliği ValidationAttribute tipine eşit mi?

            return ((ControllerActionDescriptor)filterContext.ActionDescriptor).MethodInfo.CustomAttributes.Any(filter => filter.AttributeType == typeof(ValidationAttribute));
        }
    }
}
