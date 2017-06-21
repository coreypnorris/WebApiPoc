using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using WebApiPoc.Core.Repositories;
using WebApiPoc.Core.Repositories.Interfaces;
using WebApiPoc.Persistence.Interfaces;

namespace WebApiPoc.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        public IDbContext DbContext { get; private set; }
        public ICourseRepository Courses { get; private set; }

        public UnitOfWork()
        {
            DbContext = new DbContext();
            Courses = new CourseRepository(DbContext.GetSchema());
        }

        public void Complete()
        {
            string jsonFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.ToString(), "App_Data\\schema.json");
            using (StreamWriter file = File.CreateText(jsonFile))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, DbContext.GetSchema());
            }
        }
    }
}