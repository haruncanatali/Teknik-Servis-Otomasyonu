using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Entities.Mapping
{
    public class KategoriMap:EntityTypeConfiguration<Kategori>
    {
        public KategoriMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(c => c.KategoriAd).HasMaxLength(100).IsRequired();

            this.ToTable("Kategori");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.KategoriAd).HasColumnName("KategoriAd");
        }
    }
}
