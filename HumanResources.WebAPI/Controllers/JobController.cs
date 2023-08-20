using HumanResources.Business.Abstract;
using HumanResources.Business.ActionFilter;
using HumanResources.Business.Attributes;
using HumanResources.Business.ValidationRules.Job;
using HumanResources.Entities.Dto.Job;
using Microsoft.AspNetCore.Mvc;

namespace HumanResources.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobController : Controller
    {
        private readonly IJobBusiness _jobBusiness;

        public JobController(IJobBusiness jobBusiness)
        {
            _jobBusiness = jobBusiness;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _jobBusiness.GetAll();
            return Ok(result);
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilter))]
        [Validation(typeof(JobInsertValidationRule))]
        public IActionResult Insert(JobInsertDto jobInsertDto)
        {
            var result = _jobBusiness.Insert(jobInsertDto);
            return Ok(result);
        }

        [HttpPut]
        [HttpPost]
        [ServiceFilter(typeof(ValidationFilter))]
        [Validation(typeof(JobUpdateValidationRule))]
        public IActionResult Update(JobUpdateDto jobUpdateDto)
        {
            var result = _jobBusiness.Update(jobUpdateDto);
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            var result = _jobBusiness.Delete(id);
            return Ok(result);
        }
    }
}
