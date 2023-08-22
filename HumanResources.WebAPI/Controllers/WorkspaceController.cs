using HumanResources.Business.Abstract;
using HumanResources.Entities.Dto.Workspace;
using Microsoft.AspNetCore.Mvc;

namespace HumanResources.WebAPI.Controllers
{
    [ApiController]
    [Route("workspace")]
    public class WorkspaceController : Controller
    {
        private readonly IWorkspaceBusiness _workspaceBusiness;

        public WorkspaceController(IWorkspaceBusiness workspaceBusiness)
        {
            _workspaceBusiness = workspaceBusiness;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _workspaceBusiness.GetAll();
            return Ok(result);
        }

        [HttpPost]
        //[ServiceFilter(typeof(ValidationFilter))]
        //[Validation(typeof(JobInsertValidationRule))]
        public IActionResult Insert(WorkspaceInsertDto workspaceInsertDto)
        {
            var result = _workspaceBusiness.Insert(workspaceInsertDto);
            return Ok(result);
        }

        [HttpPut]
        //[ServiceFilter(typeof(ValidationFilter))]
        //[Validation(typeof(JobUpdateValidationRule))]
        public IActionResult Update(WorkspaceUpdateDto workspaceUpdateDto)
        {
            var result = _workspaceBusiness.Update(workspaceUpdateDto);
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            var result = _workspaceBusiness.Delete(id);
            return Ok(result);
        }
    }
}
