using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Entities.Dto.Language
{
    public class LanguageUpdateDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string LanguageName { get; set; }
        public string Level { get; set; }
    }
}
