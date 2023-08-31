using AutoMapper;
using HumanResources.Business.Abstract;
using HumanResources.Core.Utilities.Result;
using HumanResources.DataAccess.Abstract;
using HumanResources.Entities.Concrete;
using HumanResources.Entities.Dto.ApplyForJob;

namespace HumanResources.Business.Concrete
{
    public class ApplyForJobBusiness : IApplyForJobBusiness
    {
        private readonly IApplyForJobRepository _applyForJobRepository;
        private readonly IMapper _mapper;

        public ApplyForJobBusiness(IApplyForJobRepository applyForJobRepository, IMapper mapper)
        {
            _applyForJobRepository = applyForJobRepository;
            _mapper = mapper;
        }

        public IResult Insert(ApplyForJobInsertDto applyForJobInsertDto)
        {
            var checkApplyForJob = _applyForJobRepository.Get(x => x.JobId == applyForJobInsertDto.JobId && x.UserId == applyForJobInsertDto.UserId);

            if (checkApplyForJob == null)
            {
                var applyForJob = _mapper.Map<ApplyForJob>(applyForJobInsertDto);
                _applyForJobRepository.Insert(applyForJob);
                return new SuccessResult();
            }

            return new ErrorResult("Bu iş ilanına daha önceden başvuru yapılmış.");
        }

        public IResult Update(ApplyForJobUpdateDto applyForJobUpdateDto)
        {
            var findApplyForJob = _applyForJobRepository.Get(x => x.Id == applyForJobUpdateDto.Id);

            if (findApplyForJob != null)
            {
                var applyForJob = _mapper.Map(applyForJobUpdateDto, findApplyForJob);
                _applyForJobRepository.Update(applyForJob);
                return new SuccessResult();
            }

            return new ErrorResult("Böyle bir iş başvurusu bulunamadı.");
        }

        public IResult Delete(Guid id)
        {
            var findApplyForJob = _applyForJobRepository.Get(x => x.Id == id);

            if (findApplyForJob != null)
            {
                _applyForJobRepository.Delete(findApplyForJob);
                return new SuccessResult();
            }

            return new ErrorResult("Böyle bir iş başvurusu bulunamadı.");
        }

        public IDataResult<List<ApplyForJobDto>> GetAll()
        {
            var applyForJobList = _applyForJobRepository.GetAll();

            if (applyForJobList.Any())
            {
                var applyForJobs = _mapper.Map<List<ApplyForJobDto>>(applyForJobList);
                return new SuccessDataResult<List<ApplyForJobDto>>(applyForJobs);
            }

            return new ErrorDataResult<List<ApplyForJobDto>>("Aktif iş başvuru listesi bulunamadı.");
        }

        public IDataResult<ApplyForJobDto> GetById(Guid id)
        {
            var findApplyForJob = _applyForJobRepository.Get(x => x.Id == id);

            if (findApplyForJob != null)
            {
                var applyForJob = _mapper.Map<ApplyForJobDto>(findApplyForJob);
                return new SuccessDataResult<ApplyForJobDto>(applyForJob);
            }

            return new ErrorDataResult<ApplyForJobDto>("İş başvurusu bulunamadı.");
        }
    }
}
