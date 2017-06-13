using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using WebApiPoc.Core.Models;
using WebApiPoc.Persistence.Interfaces;

namespace WebApiPoc.Persistence
{
    public class Schema : ISchema
    {
        private readonly SchemaModel _schema;
        public Schema()
        {
            string jsonFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.ToString(), "App_Data\\schema.json");
            SchemaModel schema;
            using (StreamReader reader = new StreamReader(jsonFile))
            {
                var data = reader.ReadToEnd();
                schema = JsonConvert.DeserializeObject<SchemaModel>(data);
            }
            _schema = schema;
        }

        public SchemaModel GetSchema()
        {
            return _schema;
        }
    }

    public class SchemaModel
    {
        public IEnumerable<CourseModel> Courses { get; set; }
    }
}