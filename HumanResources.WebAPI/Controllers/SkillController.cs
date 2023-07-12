using HumanResources.Business.Abstract;
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

        [HttpPost]
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
        public IActionResult Update(SkillUpdateDto skillUpdateDto)
        {
            return Ok(_skillBusiness.Update(skillUpdateDto));
        }
    }
}
