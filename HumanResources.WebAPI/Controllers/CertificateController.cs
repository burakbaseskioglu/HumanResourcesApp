using HumanResources.Business.Abstract;
using HumanResources.Business.ActionFilter;
using HumanResources.Business.Attributes;
using HumanResources.Business.ValidationRules.Certificate;
using HumanResources.Entities.Dto.Certificate;
using Microsoft.AspNetCore.Mvc;

namespace HumanResources.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CertificateController : Controller
    {
        private readonly ICertificateBusiness _certificateBusiness;

        public CertificateController(ICertificateBusiness certificateBusiness)
        {
            _certificateBusiness = certificateBusiness;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_certificateBusiness.GetAll());
        }

        [HttpGet("{userId}")]
        public IActionResult GetAllCertificatesByUser(Guid userId)
        {
            return Ok(_certificateBusiness.GetAllCertificatesByUser(userId));
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilter))]
        [Validation(typeof(CertificateInsertValidationRule))]
        public IActionResult Insert(CertificateInsertDto certificateInsertDto)
        {
            return Ok(_certificateBusiness.Add(certificateInsertDto));
        }

        [HttpDelete]
        public IActionResult Delete(Guid certificateId)
        {
            return Ok(_certificateBusiness.Delete(certificateId));
        }

        [HttpPut]
        [ServiceFilter(typeof(ValidationFilter))]
        [Validation(typeof(CertificateUpdateValidationRule))]
        public IActionResult Update(CertificateUpdateDto certificateUpdateDto)
        {
            return Ok(_certificateBusiness.Update(certificateUpdateDto));
        }
    }
}
