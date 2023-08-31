using HumanResources.DataAccess.Abstract;
using HumanResources.DataAccess.Repository.EntityFramework;
using HumanResources.Entities.Concrete;
using Microsoft.Extensions.Configuration;

namespace HumanResources.DataAccess.Concrete
{
    public class ApplyForJobRepository : EfRepositoryBase<ApplyForJob>, IApplyForJobRepository
    {
        public ApplyForJobRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
