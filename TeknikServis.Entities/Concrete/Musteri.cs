using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Abstract;

namespace TeknikServis.Entities.Concrete
{
    public class Musteri:IEntity
    {
        public Musteri()
        {
            UrunHareketler = new List<UrunHareket>();
            FaturaBilgiler = new List<FaturaBilgi>();
            UrunKabuller = new List<UrunKabul>();
        }

        public int Id { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public string MusteriTelefon { get; set; }
        public string MusteriMail { get; set; }
        public string MusteriBanka { get; set; }
        public string MusteriVergiDaire { get; set; }
        public string MusteriVergiNo { get; set; }
        public string MusteriStatu { get; set; }
        public string MusteriIl { get; set; }
        public string MusteriIlce { get; set; }
        public string MusteriAcikAdres { get; set; }

        public virtual ICollection<UrunHareket> UrunHareketler { get; set; }
        public virtual ICollection<FaturaBilgi> FaturaBilgiler { get; set; }
        public virtual ICollection<UrunKabul> UrunKabuller { get; set; }
    }
}
