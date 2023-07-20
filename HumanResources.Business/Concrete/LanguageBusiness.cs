using AutoMapper;
using HumanResources.Business.Abstract;
using HumanResources.Core.Utilities.Result;
using HumanResources.DataAccess.Abstract;
using HumanResources.Entities.Concrete;
using HumanResources.Entities.Dto.Language;

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

        public IResult Add(LanguageInsertDto languageInsertDto)
        {
            var language = _mapper.Map<Language>(languageInsertDto);
            _languageRepository.Insert(language);
            return new SuccessResult();
        }

        public IResult Delete(Guid languageId)
        {
            var language = _languageRepository.Get(x => x.Id == languageId);

            if (language != null)
            {
                _languageRepository.SoftDelete(language);
                return new SuccessResult();
            }

            return new ErrorResult("Yabancı dil bilgisi bulunamadı.");
        }

        public IDataResult<IEnumerable<LanguageDto>> GetAll()
        {
            var languages = _languageRepository.GetAll();

            if (languages.Any())
            {
                var languageList = _mapper.Map<IEnumerable<LanguageDto>>(languages);
                return new SuccessDataResult<IEnumerable<LanguageDto>>(languageList);
            }

            return new ErrorDataResult<IEnumerable<LanguageDto>>("Yabancı dil bilgisi bulunamadı.");
        }

        public IDataResult<IEnumerable<LanguageDto>> GetAllLanguagesByUser(Guid userId)
        {
            var languages = _languageRepository.GetAll(x => x.UserId == userId);

            if (languages.Any())
            {
                var languageList = _mapper.Map<IEnumerable<LanguageDto>>(languages);
                return new SuccessDataResult<IEnumerable<LanguageDto>>(languageList);
            }

            return new ErrorDataResult<IEnumerable<LanguageDto>>("Yabancı dil bilgisi bulunamadı.");
        }

        public IResult Update(LanguageUpdateDto languageUpdateDto)
        {
            var language = _languageRepository.Get(x => x.Id == languageUpdateDto.Id);

            if (language != null)
            {
                var updatedLanguage = _mapper.Map(languageUpdateDto, language);
                _languageRepository.Update(updatedLanguage);

                return new SuccessResult();
            }

            return new ErrorResult("Yabancı dil bilgisi bulunamadı.");
        }
    }
}
