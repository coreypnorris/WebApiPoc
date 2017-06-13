using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiPoc.Core.Enums;
using WebApiPoc.Core.Models;

namespace WebApiPoc.Core.Repositories.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<CourseModel> GetOnlineCourses();
    }
}