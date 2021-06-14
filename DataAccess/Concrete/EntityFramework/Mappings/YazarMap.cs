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

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("yazarno");
            builder.Property(x => x.Ad).HasColumnName("yazarad");
            builder.Property(x => x.Soyad).HasColumnName("yazarsoyad");

        }
    }





}
