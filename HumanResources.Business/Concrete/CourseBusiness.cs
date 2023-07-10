using HumanResources.Business.Abstract;
using HumanResources.Core.Utilities.Result;
using HumanResources.DataAccess.Abstract;
using HumanResources.Entities.Dto.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Business.Concrete
{
    public class CourseBusiness : ICourseBusiness
    {
        private readonly ICourseRepository _courseRepository;

        public CourseBusiness(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public IResult Add(CourseInsertDto courseInsertDto)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Guid languageId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<CourseDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(CourseUpdateDto courseUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
