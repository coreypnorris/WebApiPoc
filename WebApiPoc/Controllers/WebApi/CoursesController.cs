using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiPoc.Core.Models;
using WebApiPoc.Persistence.Entities;
using WebApiPoc.Persistence.Interfaces;

namespace WebApiPoc.Controllers
{
    [RoutePrefix("Api/Courses")]
    public class CoursesController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        public CoursesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("Online")]
        public IEnumerable<CourseModel> GetOnlineCourses()
        {
            return _unitOfWork.Courses.GetOnlineCourses();
        }
    }
}
