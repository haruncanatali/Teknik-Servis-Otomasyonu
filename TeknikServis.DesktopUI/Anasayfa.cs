using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknikServis.DesktopUI.Formlar;
using TeknikServis.DesktopUI.Raporlar;

namespace TeknikServis.DesktopUI
{
    public partial class Anasayfa : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        UrunListesi urunListesiForm;
        Kategori kategoriForm;
        FrmIstatistik urunIstatistik;
        MusteriForm musteriForm;
        MusteriIstatistik musteriIstatistikForm;
        DepartmanForm departmanForm;
        PersonelForm personelForm;
        NotlarFom notlarForm;
        ArizaListesiForm arizaListeForm;
        SatisEkleForm satisEkleForm;
        ArizaDetayForm arizaDetayForm;
        FaturaForm faturaForm;
        HaritaForm haritaForm;
        RaporlarForm raporlarForm;
        YouTubeForm youTubeForm;
        MailForm mailForm;
        AnasayfaForm anasayfaForm;

        public Anasayfa()
        {
            InitializeComponent();
        }

        private void urunListesiBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            urunListesiForm = new UrunListesi();
            urunListesiForm.MdiParent = this;
            urunListesiForm.Show();
        }

        private void kategoriListesiBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            kategoriForm = new Kategori();
            kategoriForm.MdiParent = this;
            kategoriForm.Show();
        }

        private void urunIstatistikleriBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            urunIstatistik = new FrmIstatistik();
            urunIstatistik.MdiParent = this;
            urunIstatistik.Show();
        }

        private void musteriBarBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            musteriForm = new MusteriForm();
            musteriForm.MdiParent = this;
            musteriForm.Show();
        }

        private void musteriIstatistikBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            musteriIstatistikForm = new MusteriIstatistik();
            musteriIstatistikForm.MdiParent = this;
            musteriIstatistikForm.Show();
        }

        private void departmanlarBrBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            departmanForm = new DepartmanForm();
            departmanForm.MdiParent = this;
            departmanForm.Show();
        }

        private void personellerBrBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            personelForm = new PersonelForm();
            personelForm.MdiParent = this;
            personelForm.Show();
        }

        private void notlarBrBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            notlarForm = new NotlarFom();
            notlarForm.MdiParent = this;
            notlarForm.Show();
        }

        private void arizaliUrunListesiBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            arizaListeForm = new ArizaListesiForm();
            arizaListeForm.MdiParent = this;
            arizaListeForm.Show();
        }

        private void yeniSatisBrBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            satisEkleForm = new SatisEkleForm();
            satisEkleForm.MdiParent = this;
            satisEkleForm.Show();
        }

        private void yeniArizaliUrunKaydiBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new ArizaKaydiForm().Show();
        }

        private void arizaliUrunAciklamaBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            arizaDetayForm = new ArizaDetayForm();
            arizaDetayForm.MdiParent = this;
            arizaDetayForm.Show();
        }

        private void qrKodOlusturBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new QrKodForm().Show();
        }

        private void haritaBrBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            haritaForm = new HaritaForm();
            haritaForm.MdiParent = this;
            haritaForm.Show();
        }

        private void RaporlarBrBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            raporlarForm = new RaporlarForm();
            //raporlarForm.MdiParent = this;
            raporlarForm.Show();
        }

        private void excelBrBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE");
        }

        private void wordBrBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE");
        }

        private void powerPointBrBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Microsoft Office\root\Office16\POWERPNT.EXE");

        }

        private void hesapMakinesiBrBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void youtubeBrBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            youTubeForm = new YouTubeForm();
            youTubeForm.MdiParent = this;
            youTubeForm.Show();
        }

        private void faturaBrBtn_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            faturaForm = new FaturaForm();
            faturaForm.MdiParent = this;
            faturaForm.Show();
        }

        private void mailBrBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mailForm = new MailForm();
            //mailForm.MdiParent = this;
            mailForm.Show();
        }

        private void anasayfaBrBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            anasayfaForm = new AnasayfaForm();
            anasayfaForm.MdiParent = this;
            anasayfaForm.Show();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
