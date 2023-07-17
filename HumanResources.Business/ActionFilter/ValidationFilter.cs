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
            if (HasValidationAttribute(context))
            {
                //ConstructorArguments : Bu özniteliğe uygulanan argümanların koleksiyonunu alır.

                var arguments = ((ControllerActionDescriptor)context.ActionDescriptor).MethodInfo.CustomAttributes?
                    .FirstOrDefault(filter => filter.AttributeType == typeof(ValidationAttribute))?.ConstructorArguments;

                var validationType = arguments[0].Value;
                var objects = context.ActionArguments.Values.ToArray();
                var result = ValidationHelper.Validate((Type)validationType!, objects);

                if (!result.IsValid)
                {
                    var errorList = new List<string>();
                    foreach (var item in result.Errors)
                    {
                        errorList.Add(item.ErrorMessage);
                    }

                    context.Result = new ObjectResult(context.ModelState)
                    { 
                        Value = errorList,
                        StatusCode = 400 
                    };

                    return;
                }
                await next();
            }
        }

        public bool HasValidationAttribute(FilterContext context)
        {
            //ControllerActionDescriptor : Bir denetleyici eyleminin açıklamasını temsil eder.
            //MethodInfo : Bir yöntemin açıklamasını temsil eder.
            //CustomAttributes : Bu yönteme uygulanan öznitelikleri alır.
            //filter.AttributeType == typeof(ValidationAttribute) : filter değişkeninin AttributeType özelliği ValidationAttribute tipine eşit mi?

            return ((ControllerActionDescriptor)context.ActionDescriptor).MethodInfo.CustomAttributes.Any(filter => filter.AttributeType == typeof(ValidationAttribute));
        }
    }
}
