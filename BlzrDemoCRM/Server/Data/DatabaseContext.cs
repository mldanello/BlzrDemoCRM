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

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<ContactEntity>(entity =>
        //    { 
                
        //        entity.ToTable("Contact");
        //        entity.Property(e => e.Id).HasColumnName("Id");
        //        entity.Property(e => e.Name)
        //            .HasMaxLength(100)
        //            .IsUnicode(false);
        //        entity.Property(e => e.Address)
        //            .HasMaxLength(500)
        //            .IsUnicode(false);
        //        entity.Property(e => e.Phone)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //    });
        //    OnModelCreatingPartial(modelBuilder);
        //}
        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
