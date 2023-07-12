using HumanResources.Business.Abstract;
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

        [HttpPost]
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
        public IActionResult Update(LanguageUpdateDto languageUpdateDto)
        {
            return Ok(_languageBusiness.Update(languageUpdateDto));
        }
    }
}
