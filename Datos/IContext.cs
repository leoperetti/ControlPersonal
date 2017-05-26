using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface IContext
    {
        int SaveChanges();

        DbEntityEntry Entry(object entity);

        Database Database { get; }
    }
}
