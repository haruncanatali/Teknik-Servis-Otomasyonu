using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Abstract;

namespace TeknikServis.Entities.Concrete
{
    public class Departman:IEntity
    {
        public Departman()
        {
            Personeller = new List<Personel>();
        }

        public int Id { get; set; }
        public string DepartmanAd { get; set; }
        public string DepartmanAciklama { get; set; }

        public virtual ICollection<Personel> Personeller { get; set; }
    }
}
