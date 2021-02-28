using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Abstract;

namespace TeknikServis.Entities.Concrete
{
    public class Kategori:IEntity
    {

        public Kategori()
        {
            Urunler = new List<Urun>();
        }

        public int Id { get; set; }
        public string KategoriAd { get; set; }

        public virtual ICollection<Urun> Urunler { get; set; }
    }
}
