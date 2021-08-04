using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework.Mappings;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class KutuphaneContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=kutuphane;Trusted_Connection=true");
        }


        public DbSet<Islem> Islemler { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Tur> Turler { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new IslemMap());
            modelBuilder.ApplyConfiguration(new KitapMap());
            modelBuilder.ApplyConfiguration(new OgrenciMap());
            modelBuilder.ApplyConfiguration(new TurMap());
            modelBuilder.ApplyConfiguration(new YazarMap());
        }
    }
}
