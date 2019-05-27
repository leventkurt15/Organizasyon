namespace Organizasyon.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<Categori> Categori { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Mesaj> Mesaj { get; set; }
        public virtual DbSet<Organizasyon> Organizasyon { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>()
                .HasMany(e => e.Mesaj)
                .WithOptional(e => e.Login)
                .HasForeignKey(e => e.GonderenId);

            modelBuilder.Entity<Login>()
                .HasMany(e => e.Mesaj1)
                .WithOptional(e => e.Login1)
                .HasForeignKey(e => e.AlıcıId);
        }
    }
}
