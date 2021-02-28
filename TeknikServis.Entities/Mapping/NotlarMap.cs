using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Entities.Mapping
{
    public class NotlarMap:EntityTypeConfiguration<Notlar>
    {
        public NotlarMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(c => c.Baslik).HasMaxLength(100).IsRequired();
            this.Property(c => c.Icerik).HasMaxLength(5000).IsRequired();
            this.Property(c => c.Durum).IsOptional();

            this.ToTable("Notlar");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.Baslik).HasColumnName("Baslik");
            this.Property(c => c.Icerik).HasColumnName("Icerik");
            this.Property(c => c.Durum).HasColumnName("Durum");
        }
    }
}
