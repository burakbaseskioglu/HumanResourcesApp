using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Entities.Concrete
{
    public class UserDetails
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public bool Gender { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Address { get; set; }
        public string MilitaryServiceStatus { get; set; }
        public string BloodType { get; set; }
        public string MaritalStatus { get; set; }
        public string DrivingLicense { get; set; }
    }
}
