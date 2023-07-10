using HumanResources.Core.Utilities.Result;
using HumanResources.Entities.Dto.Course;
using HumanResources.Entities.Dto.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Business.Abstract
{
    public interface ICourseBusiness
    {
        IResult Add(CourseInsertDto courseInsertDto);
        IDataResult<IEnumerable<CourseDto>> GetAll();
        IResult Delete(Guid languageId);
        IResult Update(CourseUpdateDto courseUpdateDto);
    }
}
