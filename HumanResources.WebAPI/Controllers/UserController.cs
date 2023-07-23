using HumanResources.Business.Abstract;
using HumanResources.Business.ActionFilter;
using HumanResources.Business.Attributes;
using HumanResources.Business.ValidationRules.User;
using HumanResources.Entities.Dto.User;
using Microsoft.AspNetCore.Mvc;

namespace HumanResources.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserBusiness _userBusiness;

        public UserController(IUserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _userBusiness.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(Guid userId)
        {
            var result = _userBusiness.GetUserById(userId);
            return Ok(result);
        }

        [HttpGet("userCredentials")]
        public IActionResult GetUserCredentials()
        {
            var result = _userBusiness.GetUserCredentials();
            return Ok(result);
        }

        [HttpPut]
        [ServiceFilter(typeof(ValidationFilter))]
        [Validation(typeof(UserUpdateValidationRule))]
        public IActionResult Update(UserUpdateDto userUpdateDto)
        {
            var result = _userBusiness.Update(userUpdateDto);
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Delete(Guid userId)
        {
            var result = _userBusiness.Delete(userId);
            return Ok(result);
        }
    }
}
