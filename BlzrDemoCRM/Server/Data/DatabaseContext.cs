using Microsoft.EntityFrameworkCore;

namespace BlzrDemoCRM.Server.Data
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public virtual DbSet<ContactEntity> Contacts { get; set; } = null!;
    }
}
