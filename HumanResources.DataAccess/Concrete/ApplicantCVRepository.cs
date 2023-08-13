using HumanResources.DataAccess.Abstract;
using HumanResources.DataAccess.Repository.EntityFramework;
using HumanResources.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HumanResources.DataAccess.Concrete
{
    public class ApplicantCVRepository : EfRepositoryBase<ApplicantCV>, IApplicantCVRepository
    {
        private readonly IConfiguration _configuration;
        public ApplicantCVRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        public ApplicantCV GetCV(Guid id)
        {
            using (var context = new ApplicationDbContext(_configuration))
            {
                var applicantCv = context.Users
                .Where(x => !x.DeletedDate.HasValue && x.Id == id)
                .AsNoTracking()
                .Include(x => x.Educations)
                .ThenInclude(x => x.EducationType)
                .Include(x => x.Educations)
                .ThenInclude(x => x.EducationDegree)
                .Include(x => x.Works)
                .Include(x => x.Educations)
                .Include(x => x.Courses)
                .Include(x => x.Skills)
                .Include(x => x.Certificates)
                .Include(x => x.UserDetail)
                .Select(y => new ApplicantCV
                {
                    User = y,
                    Educations = y.Educations,
                    Works = y.Works!,
                    Languages = y.Languages!,
                    Courses = y.Courses!,
                    Skills = y.Skills!,
                    Certificates = y.Certificates!,
                    UserDetail = y.UserDetail
                }).FirstOrDefault();

                return applicantCv;
            }
        }
    }
}
