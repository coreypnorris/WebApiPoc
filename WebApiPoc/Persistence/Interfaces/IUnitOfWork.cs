using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiPoc.Core.Repositories.Interfaces;

namespace WebApiPoc.Persistence.Interfaces
{
    public interface IUnitOfWork
    {
        IDbContext DbContext { get; }
        ICourseRepository Courses { get; }
        void Complete();
    }
}