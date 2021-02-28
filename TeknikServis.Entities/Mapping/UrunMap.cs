using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Entities.Mapping
{
    public class UrunMap:EntityTypeConfiguration<Urun>
    {
        public UrunMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(c => c.UrunAd).HasMaxLength(200).IsRequired();
            this.Property(c => c.UrunMarka).HasMaxLength(75).IsRequired();
            this.Property(c => c.AlisFiyat).HasPrecision(18, 2).IsRequired();
            this.Property(c => c.SatisFiyat).HasPrecision(18, 2).IsRequired();
            this.Property(c => c.UrunStok).IsRequired();
            this.Property(c => c.UrunDurum).IsRequired();
            this.Property(c => c.KategoriId).IsRequired();

            this.ToTable("Urun");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.UrunAd).HasColumnName("UrunAd");
            this.Property(c => c.UrunMarka).HasColumnName("UrunMarka");
            this.Property(c => c.AlisFiyat).HasColumnName("AlisFiyat");
            this.Property(c => c.SatisFiyat).HasColumnName("SatisFiyat");
            this.Property(c => c.UrunStok).HasColumnName("UrunStok");
            this.Property(c => c.UrunDurum).HasColumnName("UrunDurum");
            this.Property(c => c.KategoriId).HasColumnName("KategoriId");
        }
    }
}
