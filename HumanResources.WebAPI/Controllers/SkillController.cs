using HumanResources.Business.Abstract;
using HumanResources.Business.ActionFilter;
using HumanResources.Business.Attributes;
using HumanResources.Business.Concrete;
using HumanResources.Business.ValidationRules.Skill;
using HumanResources.Entities.Dto.Skill;
using Microsoft.AspNetCore.Mvc;

namespace HumanResources.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SkillController : Controller
    {
        private readonly ISkillBusiness _skillBusiness;

        public SkillController(ISkillBusiness skillBusiness)
        {
            _skillBusiness = skillBusiness;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_skillBusiness.GetAll());
        }

        [HttpGet("{userId}")]
        public IActionResult GetAllSkillsByUser(Guid userId)
        {
            return Ok(_skillBusiness.GetAllSkillsByUser(userId));
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilter))]
        [Validation(typeof(SkillInsertValidationRule))]
        public IActionResult Insert(SkillInsertDto skillInsertDto)
        {
            return Ok(_skillBusiness.Add(skillInsertDto));
        }

        [HttpDelete]
        public IActionResult Delete(Guid skillId)
        {
            return Ok(_skillBusiness.Delete(skillId));
        }

        [HttpPut]
        [ServiceFilter(typeof(ValidationFilter))]
        [Validation(typeof(SkillUpdateValidationRule))]
        public IActionResult Update(SkillUpdateDto skillUpdateDto)
        {
            return Ok(_skillBusiness.Update(skillUpdateDto));
        }
    }
}
