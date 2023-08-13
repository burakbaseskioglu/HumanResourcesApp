using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace HumanResources.Entities.Enums
{
    public enum MilitaryServiceStatus
    {
        [Display(Name = "Terhis")]
        Terhis = 0,

        [Display(Name = "Tecil")]
        Tecil,

        [Display(Name = "Muaf")]
        Muaf,

        [Display(Name = "Bedelli Yapılacak")]
        BedelliYapılacak
    }

    public static class EnumExtension
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            var displayName = string.Empty;

            if (string.IsNullOrWhiteSpace(enumValue.ToString()))
            {
                displayName = enumValue.ToString();
            }

            displayName = enumValue!.GetType()!.GetMember(enumValue.ToString()).FirstOrDefault()?.GetCustomAttribute<DisplayAttribute>()?.GetName();

            return displayName!;
        }
    }
}
