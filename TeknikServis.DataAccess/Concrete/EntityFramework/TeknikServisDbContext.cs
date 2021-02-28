using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;
using TeknikServis.Entities.Mapping;

namespace TeknikServis.DataAccess.Concrete.EntityFramework
{
    public class TeknikServisDbContext:DbContext
    {
        public DbSet<Admin> Admin { get; set; }
        public DbSet<ArizaDetay> ArizaDetay { get; set; }
        public DbSet<Departman> Departman { get; set; }
        public DbSet<FaturaBilgi> FaturaBilgi { get; set; }
        public DbSet<FaturaDetay> FaturaDetay { get; set; }
        public DbSet<Gider> Gider { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<Notlar> Notlar { get; set; }
        public DbSet<Personel> Personel { get; set; }
        public DbSet<Urun> Urun { get; set; }
        public DbSet<UrunHareket> UrunHareket { get; set; }
        public DbSet<UrunKabul> UrunKabul { get; set; }
        public DbSet<UrunTakip> UrunTakip { get; set; }

        public TeknikServisDbContext()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //RelationShips
            modelBuilder.Entity<Departman>().HasMany(c => c.Personeller).WithRequired(c => c.Departman).HasForeignKey(c => c.DepartmanId).WillCascadeOnDelete(true);
           
            modelBuilder.Entity<Musteri>().HasMany(c => c.FaturaBilgiler).WithRequired(c => c.Musteri).HasForeignKey(c => c.MusteriId);
            modelBuilder.Entity<Musteri>().HasMany(c => c.UrunHareketler).WithRequired(c => c.Musteri).HasForeignKey(c => c.MusteriId);
            modelBuilder.Entity<Musteri>().HasMany(c => c.UrunKabuller).WithRequired(c => c.Musteri).HasForeignKey(c => c.MusteriId);

            
            modelBuilder.Entity<FaturaBilgi>().HasMany(c => c.FaturaDetaylari).WithRequired(c => c.Fatura).HasForeignKey(c => c.FaturaId).WillCascadeOnDelete(true);

            modelBuilder.Entity<Kategori>().HasMany(c => c.Urunler).WithRequired(c => c.Kategori).HasForeignKey(c => c.KategoriId).WillCascadeOnDelete(true);

            modelBuilder.Entity<Personel>().HasMany(c => c.FaturaBilgiler).WithRequired(c => c.Personel).HasForeignKey(c => c.PersonelId);
            modelBuilder.Entity<Personel>().HasMany(c => c.UrunHareketler).WithRequired(c => c.Personel).HasForeignKey(c => c.PersonelId);
            modelBuilder.Entity<Personel>().HasMany(c => c.UrunKabuller).WithRequired(c => c.Personel).HasForeignKey(c=>c.PersonelId);

            modelBuilder.Entity<Urun>().HasMany(c => c.UrunHareketler).WithRequired(c => c.Urun).HasForeignKey(c => c.UrunId);
            modelBuilder.Entity<Urun>().HasMany(c => c.UrunTakipler).WithRequired(c => c.Urun).HasForeignKey(c => c.UrunId);
            modelBuilder.Entity<Urun>().HasMany(c => c.UrunKabuller).WithRequired(c => c.Urun).HasForeignKey(c => c.UrunId);

            //Mapping

            modelBuilder.Configurations.Add(new AdminMap());
            modelBuilder.Configurations.Add(new ArizaDetayMap());
            modelBuilder.Configurations.Add(new DepartmanMap());
            modelBuilder.Configurations.Add(new FaturaBilgiMap());
            modelBuilder.Configurations.Add(new FaturaDetayMap());
            modelBuilder.Configurations.Add(new GiderMap());
            modelBuilder.Configurations.Add(new KategoriMap());
            modelBuilder.Configurations.Add(new MusteriMap());
            modelBuilder.Configurations.Add(new NotlarMap());
            modelBuilder.Configurations.Add(new PersonelMap());
            modelBuilder.Configurations.Add(new UrunHareketMap());
            modelBuilder.Configurations.Add(new UrunKabulMap());
            modelBuilder.Configurations.Add(new UrunMap());
            modelBuilder.Configurations.Add(new UrunTakipMap());


        }
    }
}
