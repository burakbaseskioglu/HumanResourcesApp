using HumanResources.Business.Abstract;
using HumanResources.Business.ActionFilter;
using HumanResources.Business.Attributes;
using HumanResources.Business.ValidationRules;
using HumanResources.Entities.Dto.Education;
using Microsoft.AspNetCore.Mvc;

namespace HumanResources.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EducationController : Controller
    {
        private readonly IEducationBusiness _educationBusiness;

        public EducationController(IEducationBusiness educationBusiness)
        {
            _educationBusiness = educationBusiness;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_educationBusiness.GetAll());
        }

        [HttpGet("{userId}")]
        public IActionResult GetAll(Guid userId)
        {
            return Ok(_educationBusiness.GetEducationsByUserId(userId));
        }

        [ServiceFilter(typeof(ValidationFilter))]
        [Validation(typeof(EducationInsertRule))]
        [HttpPost]
        public IActionResult Insert(EducationInsertDto educationInsertDto)
        {
            return Ok(_educationBusiness.Add(educationInsertDto));
        }

        [HttpDelete]
        public IActionResult Delete(Guid educationId)
        {
            return Ok(_educationBusiness.Delete(educationId));
        }

        [ServiceFilter(typeof(ValidationFilter))]
        [Validation(typeof(EducationInsertRule))]
        [HttpPut]
        public IActionResult Update(EducationUpdateDto educationUpdateDto)
        {
            return Ok(_educationBusiness.Update(educationUpdateDto));
        }

        [HttpGet("type")]
        public IActionResult GetAllEducationType()
        {
            return Ok(_educationBusiness.GetAllEducationType());
        }

        [HttpGet("degree")]
        public IActionResult GetAllEducationDegree()
        {
            return Ok(_educationBusiness.GetAllEducationDegree());
        }
    }
}
