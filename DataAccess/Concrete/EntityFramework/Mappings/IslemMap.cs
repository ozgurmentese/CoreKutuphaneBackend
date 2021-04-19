using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class IslemMap : IEntityTypeConfiguration<Islem>
    {
        public void Configure(EntityTypeBuilder<Islem> builder)
        {
            builder.ToTable(@"Islemler", "dbo");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("islemno");
            builder.Property(x => x.OgrenciNumarasi).HasColumnName("ogrno");
            builder.Property(x => x.KitapNumarasi).HasColumnName("kitapno");
            builder.Property(x => x.AlinanTarih).HasColumnName("atarih");
            builder.Property(x => x.VerilenTarih).HasColumnName("vtarih");
        }
    }
}
