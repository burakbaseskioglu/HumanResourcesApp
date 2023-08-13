using AutoMapper;
using HumanResources.Business.Abstract;
using HumanResources.Core.Utilities.Result;
using HumanResources.DataAccess.Abstract;
using HumanResources.Entities.Dto.ApplicantCv;

namespace HumanResources.Business.Concrete
{
    public class ApplicantCVBusiness : IApplicantCVBusiness
    {
        private readonly IApplicantCVRepository _applicantCVRepository;
        private readonly IMapper _mapper;

        public ApplicantCVBusiness(IApplicantCVRepository applicantCVRepository, IMapper mapper)
        {
            _applicantCVRepository = applicantCVRepository;
            _mapper = mapper;
        }

        public IDataResult<ApplicantCVDto> Get(Guid userId)
        {
            var userApplicantCV = _applicantCVRepository.GetCV(userId);

            if (userApplicantCV != null)
            {
                var applicantCV = _mapper.Map<ApplicantCVDto>(userApplicantCV);

                return new SuccessDataResult<ApplicantCVDto>(applicantCV);
            }

            return new ErrorDataResult<ApplicantCVDto>("Kullanıcıya ait bir CV bulunamadı.");
        }
    }
}
