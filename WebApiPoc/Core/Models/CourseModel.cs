using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiPoc.Core.Enums;

namespace WebApiPoc.Core.Models
{
    public class CourseModel
    {
        public string Name { get; set; }
        public CourseType Type { get; set; }
    }
}