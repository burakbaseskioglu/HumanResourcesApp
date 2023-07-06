using HumanResources.Business.Abstract;
using HumanResources.Entities;
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
            var result = _languageBusiness.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Insert(LanguageInsertDto languageInsertDto)
        {
            _languageBusiness.Add(languageInsertDto);
            return Ok();
        }
    }
}
