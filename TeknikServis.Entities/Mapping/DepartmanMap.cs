using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Entities.Mapping
{
    public class DepartmanMap:EntityTypeConfiguration<Departman>
    {
        public DepartmanMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(c => c.DepartmanAd).HasMaxLength(250).IsRequired();
            this.Property(c => c.DepartmanAciklama).HasMaxLength(5000);

            this.ToTable("Departman");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.DepartmanAd).HasColumnName("DepartmanAd");
            this.Property(c => c.DepartmanAciklama).HasColumnName("DepartmanAciklama");
        }
    }
}
