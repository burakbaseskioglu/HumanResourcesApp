using AutoMapper;
using HumanResources.Business.Abstract;
using HumanResources.DataAccess.Abstract;
using HumanResources.Entities;
using HumanResources.Entities.Concrete;

namespace HumanResources.Business.Concrete
{
    public class LanguageBusiness : ILanguageBusiness
    {
        private readonly ILanguageRepository _languageRepository;
        private readonly IMapper _mapper;

        public LanguageBusiness(ILanguageRepository languageRepository, IMapper mapper)
        {
            _languageRepository = languageRepository;
            _mapper = mapper;
        }

        public void Add(LanguageInsertDto languageInsertDto)
        {
            var language = _mapper.Map<Language>(languageInsertDto);
            _languageRepository.Insert(language);
        }

        public IEnumerable<LanguageDto> GetAll()
        {
            var languages = _languageRepository.GetAll();
            return _mapper.Map<IEnumerable<LanguageDto>>(languages);
        }
    }
}
