using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class YazarMap : IEntityTypeConfiguration<Yazar>
    {
        public void Configure(EntityTypeBuilder<Yazar> builder)
        {
            builder.ToTable(@"Yazarlar", @"dbo");

            builder.HasKey(x => x.YazarNumarasi);
            builder.Property(x => x.YazarNumarasi).HasColumnName("yazarno");
            builder.Property(x => x.YazarAd).HasColumnName("yazarad");
            builder.Property(x => x.YazarSoyad).HasColumnName("yazarsoyad");

        }
    }





}
