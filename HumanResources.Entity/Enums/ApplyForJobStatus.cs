using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Entities.Enums
{
    public enum ApplyForJobStatus
    {
        [Display(Name = "Beklemede")]
        Waiting = 0,

        [Display(Name = "Kabul Edildi. Mülakat Daveti Bekleniyor.")]
        Accepted = 1,

        [Display(Name = "Reddedildi.")]
        Rejected = 2,

        [Display(Name = "Mülakat Daveti Gönderildi.")]
        MulakatAsamasi = 3
    }
}
