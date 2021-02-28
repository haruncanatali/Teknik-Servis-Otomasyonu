using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Abstract;

namespace TeknikServis.Entities.Concrete
{
    public class FaturaBilgi:IEntity
    {
        public FaturaBilgi()
        {
            FaturaDetaylari = new List<FaturaDetay>();
        }
        public int Id { get; set; }
        public string Seri { get; set; }
        public string SiraNo { get; set; }
        public DateTime Tarih { get; set; }
        public string Saat { get; set; }
        public string VergiDaire { get; set; }

        public int MusteriId { get; set; }
        public int PersonelId { get; set; }

        public virtual Musteri Musteri { get; set; }
        public virtual Personel Personel { get; set; }
        public virtual ICollection<FaturaDetay> FaturaDetaylari { get; set; }
    }
}
