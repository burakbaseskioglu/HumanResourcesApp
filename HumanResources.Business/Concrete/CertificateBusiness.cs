using AutoMapper;
using HumanResources.Business.Abstract;
using HumanResources.Core.Utilities.Result;
using HumanResources.DataAccess.Abstract;
using HumanResources.Entities.Concrete;
using HumanResources.Entities.Dto.Certificate;

namespace HumanResources.Business.Concrete
{
    public class CertificateBusiness : ICertificateBusiness
    {
        private readonly ICertificateRepository _certificateRepository;
        private readonly IMapper _mapper;

        public CertificateBusiness(ICertificateRepository certificateRepository, IMapper mapper)
        {
            _certificateRepository = certificateRepository;
            _mapper = mapper;
        }

        public IResult Add(CertificateInsertDto certificateInsertDto)
        {
            var certificate = _mapper.Map<Certificate>(certificateInsertDto);
            _certificateRepository.Insert(certificate);
            return new SuccessResult();
        }

        public IResult Delete(Guid certificateId)
        {
            var certificate = _certificateRepository.Get(x => x.Id == certificateId);

            if (certificate != null)
            {
                _certificateRepository.SoftDelete(certificate);
                return new SuccessResult();
            }

            return new ErrorResult("Sertifika bilgisi bulunamadı.");
        }

        public IDataResult<IEnumerable<CertificateDto>> GetAll()
        {
            var certificates = _certificateRepository.GetAll();

            if (certificates.Any())
            {
                var certificateList = _mapper.Map<IEnumerable<CertificateDto>>(certificates);
                return new SuccessDataResult<IEnumerable<CertificateDto>>(certificateList);
            }

            return new ErrorDataResult<IEnumerable<CertificateDto>>("Aktif Sertifika bilgisi bulunamadı.");
        }

        public IDataResult<IEnumerable<CertificateDto>> GetAllCertificatesByUser(Guid userId)
        {
            var certificates = _certificateRepository.GetAll(x => x.UserId == userId);

            if (certificates.Any())
            {
                var certificateList = _mapper.Map<IEnumerable<CertificateDto>>(certificates);
                return new SuccessDataResult<IEnumerable<CertificateDto>>(certificateList);
            }

            return new ErrorDataResult<IEnumerable<CertificateDto>>("Aktif Sertifika bilgisi bulunamadı.");
        }

        public IResult Update(CertificateUpdateDto certificateUpdateDto)
        {
            var certificate = _certificateRepository.Get(x => x.Id == certificateUpdateDto.Id);

            if (certificate != null)
            {
                var updatedCertificate = _mapper.Map(certificateUpdateDto, certificate);
                _certificateRepository.Update(updatedCertificate);

                return new SuccessResult();
            }

            return new ErrorResult("Aktif Sertifika bilgisi bulunamadı.");
        }
    }
}
