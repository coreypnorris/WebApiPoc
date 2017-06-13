using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiPoc.Core.Enums;
using WebApiPoc.Core.Models;
using WebApiPoc.Core.Repositories.Interfaces;
using WebApiPoc.Persistence;

namespace WebApiPoc.Core.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly SchemaModel _schema;
        public CourseRepository(SchemaModel schema)
        {
            _schema = schema;
        }

        public IEnumerable<CourseModel> GetOnlineCourses()
        {
            return _schema.Courses.Where(c => c.Type == CourseType.Online);
        }
    }
}