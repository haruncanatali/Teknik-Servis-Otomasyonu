using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Entities.Mapping
{
    public class PersonelMap:EntityTypeConfiguration<Personel>
    {
        public PersonelMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(c => c.PersonelAd).HasMaxLength(45).IsRequired();
            this.Property(c => c.PersonelSoyad).HasMaxLength(45).IsRequired();
            this.Property(c => c.PersonelFotorafBaglantisi).HasMaxLength(200).IsRequired();
            this.Property(c => c.PersonelMail).HasMaxLength(100).IsRequired();
            this.Property(c => c.PersonelTelefon).HasMaxLength(16).IsRequired();
            this.Property(c => c.PersonelMaas).HasPrecision(18, 2).IsRequired();
            this.Property(c => c.DepartmanId).IsRequired();

            this.ToTable("Personel");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.PersonelAd).HasColumnName("PersonelAd");
            this.Property(c => c.PersonelSoyad).HasColumnName("PersonelSoyad");
            this.Property(c => c.PersonelFotorafBaglantisi).HasColumnName("PersonelFotorafBaglantisi");
            this.Property(c => c.PersonelMail).HasColumnName("PersonelMail");
            this.Property(c => c.PersonelTelefon).HasColumnName("PersonelTelefon");
            this.Property(c => c.PersonelMaas).HasColumnName("PersonelMaas");
            this.Property(c => c.DepartmanId).HasColumnName("DepartmanId");


        }
    }
}
