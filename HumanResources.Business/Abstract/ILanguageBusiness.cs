using HumanResources.Entities;
using HumanResources.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Business.Abstract
{
    public interface ILanguageBusiness
    {
        void Add(LanguageInsertDto languageInsertDto);
    }
}
