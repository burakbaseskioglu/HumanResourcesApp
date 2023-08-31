using HumanResources.Business.Abstract;
using HumanResources.Business.ActionFilter;
using HumanResources.Business.Attributes;
using HumanResources.Business.ValidationRules.ApplyForJob;
using HumanResources.Entities.Dto.ApplyForJob;
using Microsoft.AspNetCore.Mvc;

namespace HumanResources.WebAPI.Controllers
{
    [ApiController]
    [Route("apply-for-job")]
    public class ApplyForJobController : Controller
    {
        private readonly IApplyForJobBusiness _applyForJobBusiness;

        public ApplyForJobController(IApplyForJobBusiness applyForJobBusiness)
        {
            _applyForJobBusiness = applyForJobBusiness;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var result = _applyForJobBusiness.GetById(id);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _applyForJobBusiness.GetAll();
            return Ok(result);
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilter))]
        [Validation(typeof(ApplyForJobInsertValidationRule))]
        public IActionResult Insert(ApplyForJobInsertDto applyForJobInsertDto)
        {
            var result = _applyForJobBusiness.Insert(applyForJobInsertDto);
            return Ok(result);
        }

        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationFilter))]
        [Validation(typeof(ApplyForJobUpdateValidationRule))]
        public IActionResult Update(ApplyForJobUpdateDto applyForJobUpdateDto)
        {
            var result = _applyForJobBusiness.Update(applyForJobUpdateDto);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var result = _applyForJobBusiness.Delete(id);
            return Ok(result);
        }
    }
}
