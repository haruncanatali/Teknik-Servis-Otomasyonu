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
    public partial class MusteriIstatistik : Form
    {
        IMusteriService musteriServis;
        public MusteriIstatistik()
        {
            InitializeComponent();
            musteriServis = InstanceFactory.Get<IMusteriService>();
        }

        private void MusteriIstatistik_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            foreach (var item in musteriServis.List())
            {
                chartControl1.Series["Kayıt Sayısı"].Points.AddPoint(item.MusteriIl, musteriServis.List().Count(c => c.MusteriIl == item.MusteriIl));
            }
            foreach (var item in musteriServis.List())
            {
                chartControl2.Series["Kayıtlı Banka"].Points.AddPoint(item.MusteriBanka, musteriServis.List().Count(c => c.MusteriBanka == item.MusteriBanka));
            }
        }
    }
}
