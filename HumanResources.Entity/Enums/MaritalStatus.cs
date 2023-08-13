using System.ComponentModel.DataAnnotations;

namespace HumanResources.Entities.Enums
{
    public enum MaritalStatus
    {
        [Display(Name = "Bekar")]
        Bekar = 0,

        [Display(Name = "Evli")]
        Evli
    }
}
