using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Entities.Dto.Course
{
    public class CourseUpdateDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string CourseName { get; set; }
        public string Company { get; set; }
        public DateTime StartedDate { get; set; }
    }
}
