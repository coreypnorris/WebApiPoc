using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiPoc.Persistence.Entities;

namespace WebApiPoc.Persistence
{
    public class Schema
    {
        public IEnumerable<CourseEntity> Courses { get; set; }
    }
}