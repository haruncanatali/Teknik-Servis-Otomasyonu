using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Abstract;

namespace TeknikServis.Entities.Concrete
{
    public class UrunTakip:IEntity
    {
        public int Id { get; set; }
        public string Durum { get; set; }
        public DateTime Tarih { get; set; }
        public string TakipKodu { get; set; }

        public int UrunId { get; set; }
        public virtual Urun Urun { get; set; }
    }
}
