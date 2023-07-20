using AutoMapper;
using HumanResources.Business.Abstract;
using HumanResources.Core.Utilities.Result;
using HumanResources.DataAccess.Abstract;
using HumanResources.Entities.Concrete;
using HumanResources.Entities.Dto.Course;

namespace HumanResources.Business.Concrete
{
    public class CourseBusiness : ICourseBusiness
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public CourseBusiness(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        public IResult Add(CourseInsertDto courseInsertDto)
        {
            var course = _mapper.Map<Course>(courseInsertDto);
            _courseRepository.Insert(course);
            return new SuccessResult();
        }

        public IResult Delete(Guid courseId)
        {
            var course = _courseRepository.Get(x => x.Id == courseId);

            if (course != null)
            {
                _courseRepository.SoftDelete(course);
                return new SuccessResult();
            }

            return new ErrorResult("Kurs bilgisi bulunamadı.");
        }

        public IDataResult<IEnumerable<CourseDto>> GetAll()
        {
            var courses = _courseRepository.GetAll();

            if (courses.Any())
            {
                var coursesList = _mapper.Map<IEnumerable<CourseDto>>(courses);
                return new SuccessDataResult<IEnumerable<CourseDto>>(coursesList);
            }

            return new ErrorDataResult<IEnumerable<CourseDto>>("Kurs bilgisi bulunamadı.");
        }

        public IDataResult<IEnumerable<CourseDto>> GetAllCoursesByUser(Guid userId)
        {
            var courses = _courseRepository.GetAll(x => x.UserId == userId);

            if (courses.Any())
            {
                var coursesList = _mapper.Map<IEnumerable<CourseDto>>(courses);
                return new SuccessDataResult<IEnumerable<CourseDto>>(coursesList);
            }

            return new ErrorDataResult<IEnumerable<CourseDto>>("Kurs bilgisi bulunamadı.");
        }

        public IResult Update(CourseUpdateDto courseUpdateDto)
        {
            var course = _courseRepository.Get(x => x.Id == courseUpdateDto.Id);

            if (course != null)
            {
                var updatedCourse = _mapper.Map(courseUpdateDto, course);
                _courseRepository.Update(updatedCourse);

                return new SuccessResult();
            }

            return new ErrorResult("Kurs bilgisi bulunamadı.");
        }
    }
}
