using static WebApiPoc.Persistence.Schema;

namespace WebApiPoc.Persistence.Interfaces
{
    public interface ISchema
    {
        SchemaModel GetSchema();
    }
}