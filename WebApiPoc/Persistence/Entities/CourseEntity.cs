using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiPoc.Persistence.Enums;

namespace WebApiPoc.Persistence.Entities
{
    public class CourseEntity
    {
        public string Name { get; set; }
        public CourseType Type { get; set; }
    }
}