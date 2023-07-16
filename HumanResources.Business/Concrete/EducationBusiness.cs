using AutoMapper;
using HumanResources.Business.Abstract;
using HumanResources.Core.Utilities.Result;
using HumanResources.DataAccess.Abstract;
using HumanResources.Entities.Concrete;
using HumanResources.Entities.Dto.Education;

namespace HumanResources.Business.Concrete
{
    public class EducationBusiness : IEducationBusiness
    {
        private readonly IEducationRepository _educationRepository;
        private readonly IEducationTypeRepository _educationTypeRepository;
        private readonly IEducationDegreeRepository _educationDegreeRepository;
        private readonly IMapper _mapper;

        public EducationBusiness(
            IEducationRepository educationRepository,
            IEducationTypeRepository educationTypeRepository,
            IEducationDegreeRepository educationDegreeRepository,
            IMapper mapper)
        {
            _educationRepository = educationRepository;
            _educationTypeRepository = educationTypeRepository;
            _educationDegreeRepository = educationDegreeRepository;
            _mapper = mapper;
        }

        public IResult Add(EducationInsertDto educationInsertDto)
        {
            var education = _mapper.Map<Education>(educationInsertDto);
            _educationRepository.Insert(education);
            return new SuccessResult();
        }

        public IResult Delete(Guid educationId)
        {
            var education = _educationRepository.Get(x => x.Id == educationId);

            if (education != null)
            {
                _educationRepository.SoftDelete(education);
                return new SuccessResult();
            }

            return new ErrorResult("Eğitim bilgisi bulunamadı.");
        }

        public IDataResult<IEnumerable<EducationDto>> GetAll()
        {
            var educations = _educationRepository.GetAllEducationsWithUserInfo();

            if (educations.Any())
            {
                var educationList = _mapper.Map<IEnumerable<EducationDto>>(educations);
                return new SuccessDataResult<IEnumerable<EducationDto>>(educationList);
            }

            return new ErrorDataResult<IEnumerable<EducationDto>>("Eğitim bilgisi bulunamadı.");
        }

        public IDataResult<IEnumerable<EducationDegreeDto>> GetAllEducationDegree()
        {
            var educationDegrees = _educationDegreeRepository.GetAll();
            if (educationDegrees != null)
            {
                var educationDegreeList = _mapper.Map<IEnumerable<EducationDegreeDto>>(educationDegrees);
                return new SuccessDataResult<IEnumerable<EducationDegreeDto>>(educationDegreeList);
            }

            return new ErrorDataResult<IEnumerable<EducationDegreeDto>>("Aktif öğrenim türü bulunamadı.");
        }

        public IDataResult<IEnumerable<EducationTypeDto>> GetAllEducationType()
        {
            var educationTypes = _educationTypeRepository.GetAll();
            if (educationTypes != null)
            {
                var educationTypeList = _mapper.Map<IEnumerable<EducationTypeDto>>(educationTypes);
                return new SuccessDataResult<IEnumerable<EducationTypeDto>>(educationTypeList);
            }

            return new ErrorDataResult<IEnumerable<EducationTypeDto>>("Aktif öğrenim tipi bulunamadı.");
        }

        public IDataResult<IEnumerable<EducationDto>> GetEducationsByUserId(Guid id)
        {
            var educations = _educationRepository.GetAllEducationsWithUserInfo(x => x.UserId == id);

            if (educations != null)
            {
                var userEducationList = _mapper.Map<IEnumerable<EducationDto>>(educations);
                return new SuccessDataResult<IEnumerable<EducationDto>>(userEducationList);
            }

            return new ErrorDataResult<IEnumerable<EducationDto>>("Aktif öğrenim listesi bulunamadı.");
        }

        public IResult Update(EducationUpdateDto educationUpdateDto)
        {
            var education = _educationRepository.Get(x => x.Id == educationUpdateDto.Id);

            if (education != null)
            {
                var updatededucation = _mapper.Map(educationUpdateDto, education);
                _educationRepository.Update(updatededucation);

                return new SuccessResult();
            }

            return new ErrorResult("Eğitim bilgisi bulunamadı.");
        }
    }
}
