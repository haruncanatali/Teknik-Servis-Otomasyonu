using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Entities.Mapping
{
    public class FaturaDetayMap:EntityTypeConfiguration<FaturaDetay>
    {
        public FaturaDetayMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(c => c.UrunAd).HasMaxLength(200).IsRequired();
            this.Property(c => c.Adet).IsRequired();
            this.Property(c => c.Fiyat).HasPrecision(18, 2).IsRequired();
            this.Property(c => c.Tutar).HasPrecision(18, 2).IsRequired();
            this.Property(c => c.FaturaId).IsRequired();

            this.ToTable("FaturaDetay");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.UrunAd).HasColumnName("UrunAd");
            this.Property(c => c.Adet).HasColumnName("Adet");
            this.Property(c => c.Fiyat).HasColumnName("Fiyat");
            this.Property(c => c.Tutar).HasColumnName("Tutar");
            this.Property(c => c.FaturaId).HasColumnName("FaturaId");
        }
    }
}
