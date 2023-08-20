using HumanResources.DataAccess.Abstract;
using HumanResources.DataAccess.Repository.EntityFramework;
using HumanResources.Entities.Concrete;
using Microsoft.Extensions.Configuration;

namespace HumanResources.DataAccess.Concrete
{
    public class WorkspaceRepository : EfRepositoryBase<Workspace>, IWorkspaceRepository
    {
        public WorkspaceRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
