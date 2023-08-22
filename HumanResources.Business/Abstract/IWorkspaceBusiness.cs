using HumanResources.Core.Utilities.Result;
using HumanResources.Entities.Dto.Workspace;

namespace HumanResources.Business.Abstract
{
    public interface IWorkspaceBusiness
    {
        IResult Insert(WorkspaceInsertDto workspaceInsertDto);
        IResult Update(WorkspaceUpdateDto workspaceUpdateDto);
        IResult Delete(Guid id);
        IDataResult<IEnumerable<WorkspaceDto>> GetAll();
    }
}
