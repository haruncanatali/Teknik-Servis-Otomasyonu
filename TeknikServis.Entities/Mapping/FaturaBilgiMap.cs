using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Entities.Mapping
{
    public class FaturaBilgiMap:EntityTypeConfiguration<FaturaBilgi>
    {
        public FaturaBilgiMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(c => c.SiraNo).HasMaxLength(13).IsRequired();
            this.Property(c => c.Tarih).IsRequired();
            this.Property(c => c.Saat).HasMaxLength(5).IsRequired();
            this.Property(c => c.VergiDaire).HasMaxLength(50).IsRequired();
            this.Property(c => c.MusteriId).IsRequired();
            this.Property(c => c.PersonelId).IsRequired();

            this.ToTable("FaturaBilgi");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.Seri).HasColumnName("Seri");
            this.Property(c => c.SiraNo).HasColumnName("SiraNo");
            this.Property(c => c.Tarih).HasColumnName("Tarih");
            this.Property(c => c.Saat).HasColumnName("Saat");
            this.Property(c => c.VergiDaire).HasColumnName("VergiDaire");
            this.Property(c => c.MusteriId).HasColumnName("MusteriId");
            this.Property(c => c.PersonelId).HasColumnName("PersonelId");

        }
    }
}
