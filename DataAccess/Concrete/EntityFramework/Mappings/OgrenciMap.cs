using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class OgrenciMap : IEntityTypeConfiguration<Ogrenci>
    {
        public void Configure(EntityTypeBuilder<Ogrenci> builder)
        {
            builder.ToTable(@"Ogrenciler", "dbo");

            builder.HasKey(x => x.Numarasi);

            builder.Property(x => x.Numarasi).HasColumnName("ogrno");
            builder.Property(x => x.Adi).HasColumnName("ograd");
            builder.Property(x => x.Soyadi).HasColumnName("ogrsoyad");
            builder.Property(x => x.Cinsiyet).HasColumnName("cinsiyet");
            builder.Property(x => x.DogumTarihi).HasColumnName("dtarih");
            builder.Property(x => x.Sinif).HasColumnName("sinif");
        }
    }





}
