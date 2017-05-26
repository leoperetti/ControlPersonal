using System.Data.Entity;

namespace Datos
{
    public class ControlContext : DbContext, IContext
    {
            public ControlContext()
                : base("name=ControlEntities")
            {

            }

            public ControlContext(string connectionString)
                : base(connectionString)
            {
                Database.Connection.ConnectionString = connectionString;
            }

            //public DbSet<Usuario> Usuarios { get; set; }
        
    }
}
