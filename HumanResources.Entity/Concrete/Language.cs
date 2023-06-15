using HumanResources.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Entities.Concrete
{
    public class Language : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string LanguageName { get; set; }
        public string Level { get; set; }
    }
}
