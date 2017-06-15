using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using WebApiPoc.Persistence.Entities;
using WebApiPoc.Persistence.Interfaces;

namespace WebApiPoc.Persistence
{
    public class DbContext : IDbContext
    {
        private readonly Schema _schema;
        public DbContext()
        {
            string jsonFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.ToString(), "App_Data\\schema.json");
            Schema schema;
            using (StreamReader reader = new StreamReader(jsonFile))
            {
                var data = reader.ReadToEnd();
                schema = JsonConvert.DeserializeObject<Schema>(data);
            }
            _schema = schema;
        }

        public Schema GetSchema()
        {
            return _schema;
        }
    }
}