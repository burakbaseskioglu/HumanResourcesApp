using AutoMapper;
using HumanResources.Business.Abstract;
using HumanResources.Core.Utilities.Result;
using HumanResources.DataAccess.Abstract;
using HumanResources.Entities.Concrete;
using HumanResources.Entities.Dto.Job;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HumanResources.Business.Concrete
{
    public class JobBusiness : IJobBusiness
    {
        private readonly IJobRepository _jobRepository;
        private readonly IMapper _mapper;

        public JobBusiness(IJobRepository jobRepository, IMapper mapper)
        {
            _jobRepository = jobRepository;
            _mapper = mapper;
        }

        public IResult Delete(Guid id)
        {
            var job = _jobRepository.Get(x => x.Id == id);

            if (job != null)
            {
                _jobRepository.SoftDelete(job);
                return new SuccessResult();
            }

            return new ErrorResult("İş İlanı bulunamadı.");
        }

        public IDataResult<IEnumerable<JobDto>> GetAll()
        {
            var jobs = _jobRepository.GetJobs();

            if (jobs.Any())
            {
                var jobList = _mapper.Map<IEnumerable<JobDto>>(jobs);
                return new SuccessDataResult<IEnumerable<JobDto>>(jobList);
            }

            return new ErrorDataResult<IEnumerable<JobDto>>("Aktif İş İlanı listesi bulunamadı.");
        }

        public IDataResult<IEnumerable<JobDto>> GetJobsByFilter(JobFilterDto? jobFilterDto)
        {
            var jobs = _jobRepository.GetJobs(jobFilterDto.Ids);

            if (jobs.Any())
            {
                var jobList = _mapper.Map<IEnumerable<JobDto>>(jobs);
                return new SuccessDataResult<IEnumerable<JobDto>>(jobList);
            }

            return new ErrorDataResult<IEnumerable<JobDto>>("Aktif İş İlanı listesi bulunamadı.");
        }

        public IResult Insert(JobInsertDto jobInsertDto)
        {
            var checkTheJob = _jobRepository.Get(x => x.Title.Contains(jobInsertDto.Title));

            if (checkTheJob == null)
            {
                var job = _mapper.Map<Job>(jobInsertDto);
                _jobRepository.Insert(job);
                return new SuccessResult();
            }

            return new ErrorResult("Açılmaya çalışılan ilan zaten mevcut!");
        }

        public IResult Update(JobUpdateDto jobUpdateDto)
        {
            var job = _jobRepository.Get(x => x.Id == jobUpdateDto.Id);

            if (job != null)
            {
                var updatedJob = _mapper.Map(jobUpdateDto, job);
                return new SuccessResult();
            }

            return new ErrorResult("İş İlanı bulunamadı.");
        }
    }
}
