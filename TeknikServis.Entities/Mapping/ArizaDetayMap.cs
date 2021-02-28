using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Entities.Mapping
{
    public class ArizaDetayMap:EntityTypeConfiguration<ArizaDetay>
    {
        public ArizaDetayMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(c => c.Sorun).HasMaxLength(500).IsRequired();
            this.Property(c => c.Aciklama).HasMaxLength(2500);
            this.Property(c => c.Yapilanİslemler).HasMaxLength(3000);
            this.Property(c => c.OnFiyat).HasPrecision(18,2).IsRequired();
            this.Property(c => c.NetFiyat).HasPrecision(18, 2);

            this.ToTable("ArizaDetay");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.Sorun).HasColumnName("Sorun");
            this.Property(c => c.Aciklama).HasColumnName("Aciklama");
            this.Property(c => c.Yapilanİslemler).HasColumnName("Yapilanİslemler");
            this.Property(c => c.OnFiyat).HasColumnName("OnFiyat");
            this.Property(c => c.NetFiyat).HasColumnName("NetFiyat");


        }
    }
}
