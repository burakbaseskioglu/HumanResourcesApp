using HumanResources.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Entities.Concrete
{
    public class Course : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string CourseName { get; set; }
        public string Company { get; set; }
        public DateTime StartedDate { get; set; }
    }
}
