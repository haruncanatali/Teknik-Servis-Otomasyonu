using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Abstract;

namespace TeknikServis.Entities.Concrete
{
    public class UrunHareket:IEntity
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }

        public int UrunId { get; set; }
        public int MusteriId { get; set; }
        public int PersonelId { get; set; }

        public string SeriNo { get; set; }

        public virtual Urun Urun { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual Personel Personel { get; set; }
    }
}
