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
    public partial class AnasayfaForm : Form
    {
        IMusteriService musteriServis;
        public AnasayfaForm()
        {
            InitializeComponent();
            musteriServis = InstanceFactory.Get<IMusteriService>();
        }

        private void AnasayfaForm_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.tcmb.gov.tr/wps/wcm/connect/tr/tcmb+tr/main+page+site+area/bugun");

            gridControl1.DataSource = from item in musteriServis.List()
                                      select new
                                      {
                                          item.MusteriAd,
                                          item.MusteriSoyad,
                                          item.MusteriTelefon,
                                          item.MusteriStatu
                                      };
            webBrowser2.Navigate("https://www.kariyer.net/");
        }
    }
}
