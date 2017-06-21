using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiPoc.Persistence.Entities;
using WebApiPoc.Persistence.Enums;

namespace WebApiPoc.Core.Models
{
    public class CourseModel
    {
        public CourseModel(CourseEntity course)
        {
            Name = course.Name;
            CourseType = course.Type.ToString();
        }

        public string Name { get; set; }
        public string CourseType { get; set; }
    }
}