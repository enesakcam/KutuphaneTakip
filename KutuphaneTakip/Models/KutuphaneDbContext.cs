using Microsoft.EntityFrameworkCore;

namespace KutuphaneTakip.Models
{
    public class KutuphaneDbContext : DbContext
    {
        string baglanti = "Server=(localdb)\\mssqllocaldb;Database=KutuphaneDb;Trusted_Connection=True; ";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(baglanti);
        }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Adres> Adresler { get; set; }
        public DbSet<KitapTur> KitapTurler { get; set; }
        public DbSet<Islem> Islemler { get; set; }
    }
}
