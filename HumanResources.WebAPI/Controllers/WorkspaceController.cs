using HumanResources.Business.Abstract;
using HumanResources.Business.ActionFilter;
using HumanResources.Business.Attributes;
using HumanResources.Business.ValidationRules.Workspace;
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
        [ServiceFilter(typeof(ValidationFilter))]
        [Validation(typeof(WorkspaceInsertValidationRules))]
        public IActionResult Insert(WorkspaceInsertDto workspaceInsertDto)
        {
            var result = _workspaceBusiness.Insert(workspaceInsertDto);
            return Ok(result);
        }

        [HttpPut]
        [ServiceFilter(typeof(ValidationFilter))]
        [Validation(typeof(WorkspaceUpdateValidationRules))]
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
