﻿using HumanResources.DataAccess.Repository;
using HumanResources.Entities.Concrete;

namespace HumanResources.DataAccess.Abstract
{
    public interface ICourseRepository : IRepository<Course>
    {
        List<Course> GetAllCoursesWithUserInfo();
    }
}
