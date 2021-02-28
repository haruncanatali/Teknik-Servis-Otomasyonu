using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Abstract;

namespace TeknikServis.Entities.Concrete
{
    public class Personel:IEntity
    {
        public Personel()
        {
            UrunHareketler = new List<UrunHareket>();
            FaturaBilgiler = new List<FaturaBilgi>();
            UrunKabuller = new List<UrunKabul>();
        }
        public int Id { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public string PersonelFotorafBaglantisi { get; set; }
        public string PersonelMail { get; set; }
        public string PersonelTelefon { get; set; }
        public decimal PersonelMaas { get; set; }

        public int DepartmanId { get; set; }

        public virtual Departman Departman { get; set; }
        public virtual ICollection<UrunHareket>  UrunHareketler{ get; set; }
        public virtual ICollection<FaturaBilgi> FaturaBilgiler { get; set; }
        public virtual ICollection<UrunKabul> UrunKabuller { get; set; }
    }
}
