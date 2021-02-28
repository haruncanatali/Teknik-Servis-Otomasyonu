using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Abstract;

namespace TeknikServis.Entities.Concrete
{
    public class Admin:IEntity
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSifre { get; set; }
    }
}
