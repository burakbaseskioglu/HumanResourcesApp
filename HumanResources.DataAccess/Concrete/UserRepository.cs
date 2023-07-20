using HumanResources.DataAccess.Abstract;
using HumanResources.DataAccess.Repository.EntityFramework;
using HumanResources.Entities.Concrete;
using Microsoft.Extensions.Configuration;

namespace HumanResources.DataAccess.Concrete
{
    public class UserRepository : EfRepositoryBase<User>, IUserRepository
    {
        public UserRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
