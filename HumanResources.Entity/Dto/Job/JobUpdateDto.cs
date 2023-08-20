using HumanResources.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Entities.Dto.Job
{
    public class JobUpdateDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime EndDate { get; set; }
        public int WorkType { get; set; }
        public Guid WorkspaceId { get; set; }
    }
}
