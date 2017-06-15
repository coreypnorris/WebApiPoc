using static WebApiPoc.Persistence.DbContext;

namespace WebApiPoc.Persistence.Interfaces
{
    public interface IDbContext
    {
        Schema GetSchema();
    }
}