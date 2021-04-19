using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class TurMap : IEntityTypeConfiguration<Tur>
    {
        public void Configure(EntityTypeBuilder<Tur> builder)
        {
            builder.ToTable(@"Turler", @"dbo");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("turno");
            builder.Property(x => x.TurAdi).HasColumnName("turadi");
        }
    }





}
