using HumanResources.Business.Abstract;
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

        [HttpPost]
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
        public IActionResult Update(WorkUpdateDto workUpdateDto)
        {
            return Ok(_workBusiness.Update(workUpdateDto));
        }
    }
}
