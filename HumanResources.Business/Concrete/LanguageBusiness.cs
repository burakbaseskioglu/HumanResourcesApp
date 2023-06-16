using HumanResources.Business.Abstract;
using HumanResources.DataAccess.Abstract;
using HumanResources.Entities;
using HumanResources.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Business.Concrete
{
    public class LanguageBusiness : ILanguageBusiness
    {
        private readonly ILanguageRepository _languageRepository;

        public LanguageBusiness(ILanguageRepository languageRepository)
        {
            _languageRepository = languageRepository;
        }

        public void Add(LanguageInsertDto languageInsertDto)
        {
            var newLanguage = new Language
            {
                CreatedDate = DateTime.Now,
                CreatedUser = Guid.NewGuid(),
                LanguageName = languageInsertDto.LanguageName,
                Level = languageInsertDto.Level,
                UserId = languageInsertDto.UserId
            };

            _languageRepository.Insert(newLanguage);
        }
    }
}
