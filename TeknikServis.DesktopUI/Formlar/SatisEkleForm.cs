using DevExpress.XtraEditors;
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
    public partial class SatisEkleForm : Form
    {
        IUrunService urunServis;
        IPersonelService personelServis;
        IMusteriService musteriServis;
        IUrunHareketService urunHareketServis;

        int id = -1;

        public SatisEkleForm()
        {
            InitializeComponent();
            urunServis = InstanceFactory.Get<IUrunService>();
            personelServis = InstanceFactory.Get<IPersonelService>();
            musteriServis = InstanceFactory.Get<IMusteriService>();
            urunHareketServis = InstanceFactory.Get<IUrunHareketService>();
        }

        private void SatisEkleForm_Load(object sender, EventArgs e)
        {
            urunLook.Properties.DataSource = from item in urunServis.List()
                                             select new
                                             {
                                                 item.Id,
                                                 item.UrunAd
                                             };
            personelLook.Properties.DataSource = from item in personelServis.List()
                                                 select new
                                                 {
                                                     item.Id,
                                                     AdSoyad = item.PersonelAd + " " + item.PersonelSoyad
                                                 };
            musteriLook.Properties.DataSource = from item in musteriServis.List()
                                                select new
                                                {
                                                    item.Id,
                                                    AdSoyad = item.MusteriAd + " " + item.MusteriSoyad
                                                };
            BindData();
        }

        private void BindData()
        {
            gridControl1.DataSource = from item in urunHareketServis.List()
                                      select new
                                      {
                                          item.Id,
                                          UrunAd = item.Urun.UrunAd,
                                          PersonelAd = item.Personel.PersonelAd,
                                          MusteriAd = item.Musteri.MusteriAd,
                                          item.Tarih,
                                          item.Fiyat,
                                          item.SeriNo,
                                          item.Adet
                                      };
        }

        private void veritabaniBtns_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;

            switch (btn.Text)
            {
                case "Kaydet":
                    Kaydet();
                    break;
                case "Güncelle":
                    Guncelle();
                    break;
                case "Sil":
                    Sil();
                    break;
                case "Temizle":
                    Temizle();
                    break;
            }
            BindData();
            Temizle();
        }

        private void Sil()
        {
            if (id != -1)
            {
                try
                {
                    urunHareketServis.Delete(new Entities.Concrete.UrunHareket
                    {
                        Id = id
                    });
                    MessageBox.Show("Satış işlemi başarı ile silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("İşlem yapılacak satış işlemini listeden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Guncelle()
        {
            if (id!=-1)
            {
                try
                {
                    urunHareketServis.Update(new Entities.Concrete.UrunHareket
                    {
                        Id = id,
                        Tarih = DateTime.Parse(tarihDateTimePic.Value.ToString()),
                        Adet = int.Parse(adetTxt.Text.ToString()),
                        Fiyat = decimal.Parse(fiyatTxt.Text.ToString()),
                        UrunId = int.Parse(urunLook.EditValue.ToString()),
                        MusteriId = int.Parse(musteriLook.EditValue.ToString()),
                        PersonelId = int.Parse(personelLook.EditValue.ToString()),
                        SeriNo = seriNoTxt.Text.ToString()
                    });
                    MessageBox.Show("Satış işlemi başarı ile güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("İşlem yapılacak satış işlemini listeden seçiniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Kaydet()
        {
            try
            {
                urunHareketServis.Add(new Entities.Concrete.UrunHareket
                {
                    Tarih = DateTime.Parse(tarihDateTimePic.Value.ToString()),
                    Adet = int.Parse(adetTxt.Text.ToString()),
                    Fiyat = decimal.Parse(fiyatTxt.Text.ToString()),
                    UrunId = int.Parse(urunLook.EditValue.ToString()),
                    MusteriId = int.Parse(musteriLook.EditValue.ToString()),
                    PersonelId = int.Parse(personelLook.EditValue.ToString()),
                    SeriNo = seriNoTxt.Text.ToString()
                });
                MessageBox.Show("Satış işlemi başarı ile kaydedildi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Temizle()
        {
            id = -1;
            fiyatTxt.Text = "";
            adetTxt.Text = "";
            seriNoTxt.Text = "";
            musteriLook.Text = null;
            personelLook.Text = null;
            urunLook.Text = null;
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            id = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            tarihDateTimePic.Value = DateTime.Parse(gridView1.GetFocusedRowCellValue("Tarih").ToString());
            adetTxt.Text = gridView1.GetFocusedRowCellValue("Adet").ToString();
            fiyatTxt.Text = gridView1.GetFocusedRowCellValue("Fiyat").ToString();
            seriNoTxt.Text = gridView1.GetFocusedRowCellValue("SeriNo").ToString();
            urunLook.Text = gridView1.GetFocusedRowCellValue("UrunAd").ToString();
            personelLook.Text = gridView1.GetFocusedRowCellValue("PersonelAd").ToString();
            musteriLook.Text = gridView1.GetFocusedRowCellValue("MusteriAd").ToString();
        }
    }
}
