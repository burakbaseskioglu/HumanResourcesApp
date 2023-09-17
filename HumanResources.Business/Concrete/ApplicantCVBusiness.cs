using AutoMapper;
using HumanResources.Business.Abstract;
using HumanResources.Core.Utilities.Result;
using HumanResources.Core.Utilities.Security;
using HumanResources.Core.Utilities.Security.EncryptDecrypt;
using HumanResources.DataAccess.Abstract;
using HumanResources.Entities.Dto.ApplicantCv;

namespace HumanResources.Business.Concrete
{
    public class ApplicantCVBusiness : IApplicantCVBusiness
    {
        private readonly IApplicantCVRepository _applicantCVRepository;
        private readonly IMapper _mapper;
        private readonly IEncryption _encryption;

        public ApplicantCVBusiness(IApplicantCVRepository applicantCVRepository, IMapper mapper, IEncryption encryption)
        {
            _applicantCVRepository = applicantCVRepository;
            _mapper = mapper;
            _encryption = encryption;
        }

        public IDataResult<ApplicantCVDto> Get(Guid userId)
        {
            var userApplicantCV = _applicantCVRepository.GetCV(userId);

            if (userApplicantCV != null)
            {
                var applicantCV = _mapper.Map<ApplicantCVDto>(userApplicantCV);

                var userPublicKey = userApplicantCV.User.PublicKey;
                var userDecryptedPublicKey = _encryption.DecryptText(userPublicKey, EncryptionConstant.EncryptionPrivateKey);
                applicantCV.User.Email = _encryption.DecryptText(userApplicantCV.User.Email, userDecryptedPublicKey);
                applicantCV.User.Phone = _encryption.DecryptText(userApplicantCV.User.Phone, userDecryptedPublicKey);
                applicantCV.User.IdentityNumber = Convert.ToInt64(_encryption.DecryptText(userApplicantCV.User.IdentityNumber.ToString(), userDecryptedPublicKey));

                return new SuccessDataResult<ApplicantCVDto>(applicantCV);
            }

            return new ErrorDataResult<ApplicantCVDto>("Kullanıcıya ait bir CV bulunamadı.");
        }
    }
}
