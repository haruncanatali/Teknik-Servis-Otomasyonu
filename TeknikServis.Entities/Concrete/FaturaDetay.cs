using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Abstract;

namespace TeknikServis.Entities.Concrete
{
    public class FaturaDetay:IEntity
    {
        public int Id { get; set; }
        public string UrunAd { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Tutar { get; set; }

        public int FaturaId { get; set; }

        public virtual FaturaBilgi Fatura { get; set; }
    }
}
