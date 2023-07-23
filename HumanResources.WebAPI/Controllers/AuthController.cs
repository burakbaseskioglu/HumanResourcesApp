using HumanResources.Business.Abstract;
using HumanResources.Business.ActionFilter;
using HumanResources.Business.Attributes;
using HumanResources.Business.ValidationRules.User;
using HumanResources.Entities.Dto.Auth;
using Microsoft.AspNetCore.Mvc;

namespace HumanResources.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller
    {
        private readonly IAuthBusiness _authBusiness;

        public AuthController(IAuthBusiness authBusiness)
        {
            _authBusiness = authBusiness;
        }

        [HttpPost("register")]
        [ServiceFilter(typeof(ValidationFilter))]
        [Validation(typeof(UserInsertValidationRule))]
        public async Task<IActionResult> Register(RegisterDto userInsertDto)
        {
            var result = await _authBusiness.Register(userInsertDto);
            return Ok(result);
        }

        [HttpPost("login")]
        [ServiceFilter(typeof(ValidationFilter))]
        [Validation(typeof(UserInsertValidationRule))]
        public IActionResult Login(LoginDto loginDto)
        {
            var result = _authBusiness.Login(loginDto);
            return Ok(result);
        }
    }
}
