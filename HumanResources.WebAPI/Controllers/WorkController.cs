using HumanResources.Business.Abstract;
using HumanResources.Business.ActionFilter;
using HumanResources.Business.Attributes;
using HumanResources.Business.ValidationRules.Work;
using HumanResources.Entities.Dto.Work;
using Microsoft.AspNetCore.Mvc;

namespace HumanResources.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkController : Controller
    {
        private readonly IWorkBusiness _workBusiness;

        public WorkController(IWorkBusiness workBusiness)
        {
            _workBusiness = workBusiness;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_workBusiness.GetAll());
        }

        [HttpGet("{userId}")]
        public IActionResult GetAllWorksByUser(Guid userId)
        {
            return Ok(_workBusiness.GetAllWorksByUser(userId));
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilter))]
        [Validation(typeof(WorkInsertValidationRule))]
        public IActionResult Insert(WorkInsertDto workInsertDto)
        {
            return Ok(_workBusiness.Add(workInsertDto));
        }

        [HttpDelete]
        public IActionResult Delete(Guid workId)
        {
            return Ok(_workBusiness.Delete(workId));
        }

        [HttpPut]
        [ServiceFilter(typeof(ValidationFilter))]
        [Validation(typeof(WorkUpdateValidationRule))]
        public IActionResult Update(WorkUpdateDto workUpdateDto)
        {
            return Ok(_workBusiness.Update(workUpdateDto));
        }
    }
}
