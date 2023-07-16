using HumanResources.DataAccess.Abstract;
using HumanResources.DataAccess.Repository.EntityFramework;
using HumanResources.Entities.Concrete;
using Microsoft.Extensions.Configuration;

namespace HumanResources.DataAccess.Concrete
{
    public class EducationTypeRepository : EfRepositoryBase<EducationType>, IEducationTypeRepository
    {
        public EducationTypeRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
