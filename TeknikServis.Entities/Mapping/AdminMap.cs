using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Entities.Mapping
{
    public class AdminMap:EntityTypeConfiguration<Admin>
    {
        public AdminMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(c => c.KullaniciAdi).HasMaxLength(8).IsRequired();
            this.Property(c => c.KullaniciSifre).HasMaxLength(8).IsRequired();

            this.ToTable("Admin");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.KullaniciAdi).HasColumnName("KullaniciAdi");
            this.Property(c => c.KullaniciSifre).HasColumnName("KullaniciSifre");
        }
    }
}
