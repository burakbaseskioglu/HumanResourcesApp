using HumanResources.Business.Abstract;
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

        [HttpPost]
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
        public IActionResult Update(CertificateUpdateDto certificateUpdateDto)
        {
            return Ok(_certificateBusiness.Update(certificateUpdateDto));
        }
    }
}
