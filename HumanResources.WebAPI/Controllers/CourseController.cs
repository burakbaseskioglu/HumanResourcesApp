using HumanResources.Business.Abstract;
using HumanResources.Entities.Dto.Course;
using Microsoft.AspNetCore.Mvc;

namespace HumanResources.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : Controller
    {
        private readonly ICourseBusiness _courseBusiness;

        public CourseController(ICourseBusiness courseBusiness)
        {
            _courseBusiness = courseBusiness;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_courseBusiness.GetAll());
        }

        [HttpPost]
        public IActionResult Insert(CourseInsertDto courseInsertDto)
        {
            return Ok(_courseBusiness.Add(courseInsertDto));
        }

        [HttpDelete]
        public IActionResult Delete(Guid courseId)
        {
            return Ok(_courseBusiness.Delete(courseId));
        }

        [HttpPut]
        public IActionResult Update(CourseUpdateDto courseUpdateDto)
        {
            return Ok(_courseBusiness.Update(courseUpdateDto));
        }
    }
}
