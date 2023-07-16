using HumanResources.DataAccess.Abstract;
using HumanResources.DataAccess.Repository;
using HumanResources.DataAccess.Repository.EntityFramework;
using HumanResources.Entities.Concrete;
using Microsoft.Extensions.Configuration;

namespace HumanResources.DataAccess.Concrete
{
    public class EducationDegreeRepository : EfRepositoryBase<EducationDegree>, IEducationDegreeRepository
    {
        public EducationDegreeRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
