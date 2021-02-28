using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Entities.Mapping
{
    public class UrunKabulMap:EntityTypeConfiguration<UrunKabul>
    {
        public UrunKabulMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(c => c.GelisTarihi).IsRequired();
            this.Property(c => c.CikisTarihi).IsRequired();
            this.Property(c => c.UrunId).IsRequired();
            this.Property(c => c.MusteriId).IsRequired();
            this.Property(c => c.PersonelId).IsRequired();

            this.ToTable("UrunKabul");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.GelisTarihi).HasColumnName("GelisTarihi");
            this.Property(c => c.CikisTarihi).HasColumnName("CikisTarihi");
            this.Property(c => c.UrunId).HasColumnName("UrunId");
            this.Property(c => c.MusteriId).HasColumnName("MusteriId");
            this.Property(c => c.PersonelId).HasColumnName("PersonelId");

        }
    }
}
