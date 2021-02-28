using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Entities.Mapping
{
    public class MusteriMap:EntityTypeConfiguration<Musteri>
    {
        public MusteriMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(c => c.MusteriAd).HasMaxLength(40).IsRequired();
            this.Property(c => c.MusteriSoyad).HasMaxLength(40).IsRequired();
            this.Property(c => c.MusteriTelefon).HasMaxLength(16).IsRequired();
            this.Property(c => c.MusteriMail).HasMaxLength(100).IsRequired();
            this.Property(c => c.MusteriBanka).HasMaxLength(100).IsRequired();
            this.Property(c => c.MusteriVergiDaire).HasMaxLength(100).IsRequired();
            this.Property(c => c.MusteriVergiNo).HasMaxLength(10).IsRequired();
            this.Property(c => c.MusteriStatu).HasMaxLength(100).IsRequired();
            this.Property(c => c.MusteriIl).HasMaxLength(35).IsRequired();
            this.Property(c => c.MusteriIlce).HasMaxLength(35).IsRequired();
            this.Property(c => c.MusteriAcikAdres).HasMaxLength(250).IsRequired();

            this.ToTable("Musteri");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.MusteriAd).HasColumnName("MusteriAd");
            this.Property(c => c.MusteriSoyad).HasColumnName("MusteriSoyad");
            this.Property(c => c.MusteriTelefon).HasColumnName("MusteriTelefon");
            this.Property(c => c.MusteriMail).HasColumnName("MusteriMail");
            this.Property(c => c.MusteriBanka).HasColumnName("MusteriBanka");
            this.Property(c => c.MusteriVergiDaire).HasColumnName("MusteriVergiDaire");
            this.Property(c => c.MusteriTelefon).HasColumnName("MusteriTelefon");
            this.Property(c => c.MusteriVergiNo).HasColumnName("MusteriVergiNo");
            this.Property(c => c.MusteriStatu).HasColumnName("MusteriStatu");
            this.Property(c => c.MusteriIl).HasColumnName("MusteriIl");
            this.Property(c => c.MusteriIlce).HasColumnName("MusteriIlce");
            this.Property(c => c.MusteriAcikAdres).HasColumnName("MusteriAcikAdres");

        }
    }
}
