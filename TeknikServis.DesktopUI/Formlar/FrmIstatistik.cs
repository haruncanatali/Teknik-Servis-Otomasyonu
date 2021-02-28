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
using TeknikServis.Entities.Concrete;

namespace TeknikServis.DesktopUI.Formlar
{
    public partial class FrmIstatistik : Form
    {
        IUrunService urunServis;
        IKategoriService kategoriServis;
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            urunServis = InstanceFactory.Get<IUrunService>();
            kategoriServis = InstanceFactory.Get<IKategoriService>();

            BindData();
        }

        private void BindData()
        {
            urunSayisiLbl.Text = urunServis.List().Count().ToString();
            kategoriSayisiLbl.Text = kategoriServis.List().Count().ToString();
            stokSayisiLbl.Text = urunServis.List().Sum(c => c.UrunStok).ToString();

            var urun = urunServis.List().OrderByDescending(c => c.UrunStok).FirstOrDefault();
            enFazlaStokSayiliUrunTxt.Text = urun.UrunAd;
            enFazlaStokSayi.Text = urun.UrunStok.ToString();

            foreach (var item in urunServis.List())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(item.UrunAd, double.Parse(item.UrunStok.ToString()));
            }

            foreach (var item in urunServis.List())
            {
                chartControl2.Series["Satış Fiyatı"].Points.AddPoint(item.UrunAd, double.Parse(item.SatisFiyat.ToString()));
            }
        }


    }
}
