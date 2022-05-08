using DataAcces.Entity;
using System.Data.Entity;

namespace DataAcces.Context
{
    public class ProjeContext : DbContext
    {
        public ProjeContext()
        {
            Database.Connection.ConnectionString = "server=.\\SQLEXPRESS;Database=HamburgerDB;Trusted_Connection=true;";
            
        }

        public DbSet<Ekstra> Ekstras { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Boyut> Boyuts { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<SiparisEkstra> SiparisEkstras { get; set; }
        public DbSet<KrediKarti> KrediKartlari { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SiparisEkstra>().HasKey(x => new { x.SiparisId, x.EkstraId });
            base.OnModelCreating(modelBuilder);

        }
    }
  
}