using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiPoc.Core.Models;
using WebApiPoc.Core.Repositories.Interfaces;
using WebApiPoc.Persistence;
using WebApiPoc.Persistence.Entities;
using WebApiPoc.Persistence.Enums;

namespace WebApiPoc.Core.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly Schema _schema;
        public CourseRepository(Schema schema)
        {
            _schema = schema;
        }

        public IEnumerable<CourseModel> GetOnlineCourses()
        {
            return _schema.Courses.Where(c => c.Type == CourseType.Online).Select(c => new CourseModel(c));
        }
    }
}