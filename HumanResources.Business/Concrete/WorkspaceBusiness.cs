using AutoMapper;
using HumanResources.Business.Abstract;
using HumanResources.Core.Utilities.Result;
using HumanResources.DataAccess.Abstract;
using HumanResources.Entities.Concrete;
using HumanResources.Entities.Dto.Workspace;

namespace HumanResources.Business.Concrete
{
    public class WorkspaceBusiness : IWorkspaceBusiness
    {
        private readonly IWorkspaceRepository _workspaceRepository;
        private readonly IMapper _mapper;

        public WorkspaceBusiness(IWorkspaceRepository workspaceRepository, IMapper mapper)
        {
            _workspaceRepository = workspaceRepository;
            _mapper = mapper;
        }

        public IResult Delete(Guid id)
        {
            var workspace = _workspaceRepository.Get(x => x.Id == id);

            if (workspace != null)
            {
                _workspaceRepository.SoftDelete(workspace);
                return new SuccessResult();
            }

            return new ErrorResult("İş Alanı bulunamadı.");
        }

        public IDataResult<IEnumerable<WorkspaceDto>> GetAll()
        {
            var workspace = _workspaceRepository.GetAll();

            if (workspace.Any())
            {
                var workspaceList = _mapper.Map<IEnumerable<WorkspaceDto>>(workspace);
                return new SuccessDataResult<IEnumerable<WorkspaceDto>>(workspaceList);
            }

            return new ErrorDataResult<IEnumerable<WorkspaceDto>>("Aktif İş Alanı listesi bulunamadı.");
        }

        public IResult Insert(WorkspaceInsertDto workspaceInsertDto)
        {
            var checkTheWorkspace = _workspaceRepository.Get(x => x.Name.Contains(workspaceInsertDto.Name));

            if (checkTheWorkspace == null)
            {
                var workspace = _mapper.Map<Workspace>(workspaceInsertDto);
                _workspaceRepository.Insert(workspace);
                return new SuccessResult();
            }

            return new ErrorResult("Açılmaya çalışılan İş Alanı zaten mevcut!");
        }

        public IResult Update(WorkspaceUpdateDto workspaceUpdateDto)
        {
            var workspace = _workspaceRepository.Get(x => x.Id == workspaceUpdateDto.Id);

            if (workspace != null)
            {
                var updatedWorkspace = _mapper.Map(workspaceUpdateDto, workspace);
                _workspaceRepository.Update(updatedWorkspace);
                return new SuccessResult();
            }

            return new ErrorResult("İş Alanı bulunamadı.");
        }
    }
}
