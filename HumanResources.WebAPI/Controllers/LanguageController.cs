using HumanResources.Business.Abstract;
using HumanResources.Business.ActionFilter;
using HumanResources.Business.Attributes;
using HumanResources.Business.ValidationRules.Language;
using HumanResources.Entities.Dto.Language;
using Microsoft.AspNetCore.Mvc;

namespace HumanResources.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LanguageController : Controller
    {
        private readonly ILanguageBusiness _languageBusiness;

        public LanguageController(ILanguageBusiness languageBusiness)
        {
            _languageBusiness = languageBusiness;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_languageBusiness.GetAll());
        }

        [HttpGet("{userId}")]
        public IActionResult GetAllCoursesByUser(Guid userId)
        {
            return Ok(_languageBusiness.GetAllLanguagesByUser(userId));
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilter))]
        [Validation(typeof(LanguageInsertValidationRule))]
        public IActionResult Insert(LanguageInsertDto languageInsertDto)
        {
            return Ok(_languageBusiness.Add(languageInsertDto));
        }

        [HttpDelete]
        public IActionResult Delete(Guid languageId)
        {
            return Ok(_languageBusiness.Delete(languageId));
        }

        [HttpPut]
        [ServiceFilter(typeof(ValidationFilter))]
        [Validation(typeof(LanguageUpdateValidationRule))]
        public IActionResult Update(LanguageUpdateDto languageUpdateDto)
        {
            return Ok(_languageBusiness.Update(languageUpdateDto));
        }
    }
}
