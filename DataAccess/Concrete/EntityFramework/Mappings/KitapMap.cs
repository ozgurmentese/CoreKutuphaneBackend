using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class KitapMap : IEntityTypeConfiguration<Kitap>
    {
        public void Configure(EntityTypeBuilder<Kitap> builder)
        {
            builder.ToTable(@"Kitaplar", "dbo");

            builder.HasKey(x => x.KitapNumarasi);

            builder.Property(x => x.KitapNumarasi).HasColumnName("kitapno");
            builder.Property(x => x.Isbnno).HasColumnName("isbnno");
            builder.Property(x => x.KitapAdi).HasColumnName("kitapadi");
            builder.Property(x => x.YazarNumarasi).HasColumnName("yazarno");
            builder.Property(x => x.TurNumarasi).HasColumnName("turno");
            builder.Property(x => x.SayfaSayisi).HasColumnName("sayfasayisi");
            builder.Property(x => x.Puan).HasColumnName("puan");
        }
    }
}
