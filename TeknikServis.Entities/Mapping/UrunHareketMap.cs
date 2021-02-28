using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Entities.Mapping
{
    public class UrunHareketMap:EntityTypeConfiguration<UrunHareket>
    {
        public UrunHareketMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(c => c.Tarih).IsRequired();
            this.Property(c => c.Adet).IsRequired();
            this.Property(c => c.Fiyat).HasPrecision(18,2).IsRequired();
            this.Property(c => c.UrunId).IsRequired();
            this.Property(c => c.MusteriId).IsRequired();
            this.Property(c => c.PersonelId).IsRequired();

            this.ToTable("UrunHareket");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.Tarih).HasColumnName("Tarih");
            this.Property(c => c.Adet).HasColumnName("Adet");
            this.Property(c => c.Fiyat).HasColumnName("Fiyat");
            this.Property(c => c.UrunId).HasColumnName("UrunId");
            this.Property(c => c.MusteriId).HasColumnName("MusteriId");
            this.Property(c => c.PersonelId).HasColumnName("PersonelId");

        }
    }
}
