using AutoMapper;
using HumanResources.Business.Abstract;
using HumanResources.Core.Utilities.Result;
using HumanResources.DataAccess.Abstract;
using HumanResources.Entities.Concrete;
using HumanResources.Entities.Dto.Work;

namespace HumanResources.Business.Concrete
{
    public class WorkBusiness : IWorkBusiness
    {
        private readonly IWorkRepository _workRepository;
        private readonly IMapper _mapper;

        public WorkBusiness(IWorkRepository workRepository, IMapper mapper)
        {
            _workRepository = workRepository;
            _mapper = mapper;
        }

        public IResult Add(WorkInsertDto workInsertDto)
        {
            var work = _mapper.Map<Work>(workInsertDto);
            _workRepository.Insert(work);
            return new SuccessResult();
        }

        public IResult Delete(Guid workId)
        {
            var work = _workRepository.Get(x => x.Id == workId);

            if (work != null)
            {
                _workRepository.SoftDelete(work);
                return new SuccessResult();
            }

            return new ErrorResult("Çalışma bilgisi bulunamadı.");
        }

        public IDataResult<IEnumerable<WorkDto>> GetAll()
        {
            var works = _workRepository.GetAll();

            if (works.Any())
            {
                var workList = _mapper.Map<IEnumerable<WorkDto>>(works);
                return new SuccessDataResult<IEnumerable<WorkDto>>(workList);
            }

            return new ErrorDataResult<IEnumerable<WorkDto>>("Çalışma bilgisi bulunamadı.");
        }

        public IResult Update(WorkUpdateDto workUpdateDto)
        {
            var work = _workRepository.Get(x => x.Id == workUpdateDto.Id);

            if (work != null)
            {
                var updatedWork = _mapper.Map(workUpdateDto, work);
                _workRepository.Update(updatedWork);

                return new SuccessResult();
            }

            return new ErrorResult("Çalışma bilgisi bulunamadı.");
        }
    }
}
