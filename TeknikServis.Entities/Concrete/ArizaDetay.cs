using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Abstract;

namespace TeknikServis.Entities.Concrete
{
    public class ArizaDetay:IEntity
    {
        public int Id { get; set; } 
        public string Sorun { get; set; } 
        public string Aciklama { get; set; } 
        public string Yapilanİslemler { get; set; } 
        public decimal OnFiyat { get; set; } 
        public decimal NetFiyat { get; set; } 

        //public int IslemId { get; set; }
    }
}
