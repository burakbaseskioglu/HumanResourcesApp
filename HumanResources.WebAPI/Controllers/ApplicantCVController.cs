using HumanResources.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HumanResources.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApplicantCVController : Controller
    {
        private readonly IApplicantCVBusiness _applicantCVBusiness;

        public ApplicantCVController(IApplicantCVBusiness applicantCVBusiness)
        {
            _applicantCVBusiness = applicantCVBusiness;
        }

        [HttpGet]
        public IActionResult Get(Guid userId)
        {
            var result = _applicantCVBusiness.Get(userId);
            return Ok(result);
        }
    }
}
