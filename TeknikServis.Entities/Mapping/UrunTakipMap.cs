﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Entities.Mapping
{
    public class UrunTakipMap:EntityTypeConfiguration<UrunTakip>
    {
        public UrunTakipMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(c => c.Durum).HasMaxLength(250).IsRequired();
            this.Property(c => c.Tarih).IsRequired();
            this.Property(c => c.TakipKodu).HasMaxLength(12).IsRequired();
            this.Property(c => c.UrunId).IsRequired();

            this.ToTable("UrunTakip");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.Durum).HasColumnName("Durum");
            this.Property(c => c.Tarih).HasColumnName("Tarih");
            this.Property(c => c.TakipKodu).HasColumnName("TakipKodu");
            this.Property(c => c.UrunId).HasColumnName("UrunId");
        }
    }
}