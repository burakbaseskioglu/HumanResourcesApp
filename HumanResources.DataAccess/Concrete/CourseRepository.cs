using HumanResources.DataAccess.Abstract;
using HumanResources.DataAccess.Repository.EntityFramework;
using HumanResources.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HumanResources.DataAccess.Concrete
{
    public class CourseRepository : EfRepositoryBase<Course>, ICourseRepository
    {
        private readonly IConfiguration _configuration;

        public CourseRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        public List<Course> GetAllCoursesWithUserInfo()
        {
            using (ApplicationDbContext context = new(_configuration))
            {
                return context.Courses.Include(x => x.User).ToList();
            }
        }
    }
}
