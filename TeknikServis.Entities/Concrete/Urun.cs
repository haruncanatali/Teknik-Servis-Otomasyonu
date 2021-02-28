using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Abstract;

namespace TeknikServis.Entities.Concrete
{
    public class Urun:IEntity
    {
        public Urun()
        {
            UrunHareketler = new List<UrunHareket>();
            UrunTakipler = new List<UrunTakip>();
            UrunKabuller = new List<UrunKabul>();
        }

        public int Id { get; set; }
        public string UrunAd { get; set; } 
        public string UrunMarka { get; set; }
        public decimal AlisFiyat { get; set; }
        public decimal SatisFiyat { get; set; }
        public int UrunStok { get; set; }
        public bool UrunDurum { get; set; }

        public int KategoriId { get; set; }

        public virtual Kategori Kategori { get; set; }
        public virtual ICollection<UrunHareket> UrunHareketler { get; set; }
        public virtual ICollection<UrunTakip> UrunTakipler { get; set; }
        public virtual ICollection<UrunKabul> UrunKabuller { get; set; }
    }
}
