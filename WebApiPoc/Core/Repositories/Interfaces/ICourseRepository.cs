using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiPoc.Core.Models;
using WebApiPoc.Persistence.Entities;

namespace WebApiPoc.Core.Repositories.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<CourseModel> GetOnlineCourses();
    }
}