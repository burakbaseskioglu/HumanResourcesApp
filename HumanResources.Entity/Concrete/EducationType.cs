using HumanResources.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace HumanResources.Entities.Concrete
{
    public class EducationType : BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
