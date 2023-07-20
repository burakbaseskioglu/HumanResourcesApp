using AutoMapper;
using HumanResources.Business.Abstract;
using HumanResources.Core.Utilities.Result;
using HumanResources.DataAccess.Abstract;
using HumanResources.Entities.Concrete;
using HumanResources.Entities.Dto.Skill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Business.Concrete
{
    public class SkillBusiness : ISkillBusiness
    {
        private readonly ISkillRepository _skillRepository;
        private readonly IMapper _mapper;

        public SkillBusiness(ISkillRepository skillRepository, IMapper mapper)
        {
            _skillRepository = skillRepository;
            _mapper = mapper;
        }

        public IResult Add(SkillInsertDto skillInsertDto)
        {
            var skill = _mapper.Map<Skill>(skillInsertDto);
            _skillRepository.Insert(skill);
            return new SuccessResult();
        }

        public IResult Delete(Guid SkillId)
        {
            var skill = _skillRepository.Get(x => x.Id == SkillId);

            if (skill != null)
            {
                _skillRepository.SoftDelete(skill);
                return new SuccessResult();
            }

            return new ErrorResult("Beceri bilgisi bulunamadı.");
        }

        public IDataResult<IEnumerable<SkillDto>> GetAll()
        {
            var skills = _skillRepository.GetAll();

            if (skills.Any())
            {
                var skillList = _mapper.Map<IEnumerable<SkillDto>>(skills);
                return new SuccessDataResult<IEnumerable<SkillDto>>(skillList);
            }

            return new ErrorDataResult<IEnumerable<SkillDto>>("Beceri bilgisi bulunamadı.");
        }

        public IDataResult<IEnumerable<SkillDto>> GetAllSkillsByUser(Guid userId)
        {
            var skills = _skillRepository.GetAll(x => x.UserId == userId);

            if (skills.Any())
            {
                var skillList = _mapper.Map<IEnumerable<SkillDto>>(skills);
                return new SuccessDataResult<IEnumerable<SkillDto>>(skillList);
            }

            return new ErrorDataResult<IEnumerable<SkillDto>>("Beceri bilgisi bulunamadı.");
        }

        public IResult Update(SkillUpdateDto SkillUpdateDto)
        {
            var skill = _skillRepository.Get(x => x.Id == SkillUpdateDto.Id);

            if (skill != null)
            {
                var updatedSkill = _mapper.Map(SkillUpdateDto, skill);
                _skillRepository.Update(updatedSkill);

                return new SuccessResult();
            }

            return new ErrorResult("Beceri bilgisi bulunamadı.");
        }
    }
}
