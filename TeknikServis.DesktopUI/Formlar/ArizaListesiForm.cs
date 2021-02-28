using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknikServis.Business.Abstract;
using TeknikServis.Business.Ninject;

namespace TeknikServis.DesktopUI.Formlar
{
    public partial class ArizaListesiForm : Form
    {
        IArizaDetayService arizaServis;
        IUrunKabulService urunKabulServis;
        public ArizaListesiForm()
        {
            InitializeComponent();
            arizaServis = InstanceFactory.Get<IArizaDetayService>();
            urunKabulServis = InstanceFactory.Get<IUrunKabulService>();
        }

        private void ArizaListesiForm_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            gridControl1.DataSource = from item in urunKabulServis.List()
                                      select new
                                      {
                                          item.Id,
                                          Urun = item.Urun.UrunAd,
                                          Musteri = item.Musteri.MusteriAd + item.Musteri.MusteriSoyad,
                                          Personel = item.Personel.PersonelAd + item.Personel.PersonelSoyad,
                                          item.GelisTarihi,
                                          item.CikisTarihi,
                                          item.SeriNo
                                      };
        }
    }
}
