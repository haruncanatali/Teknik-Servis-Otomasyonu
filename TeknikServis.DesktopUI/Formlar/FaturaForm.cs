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
    public partial class FaturaForm : Form
    {

        int faturaBilgiId = -1;
        int faturaDetayId = -1;

        IFaturaBilgiService faturaBilgiServis;
        IMusteriService musteriServis;
        IPersonelService personelServis;
        IFaturaDetayService faturaDetayServis;
        IUrunService urunServis;

        public FaturaForm()
        {
            InitializeComponent();

            faturaBilgiServis = InstanceFactory.Get<IFaturaBilgiService>();
            musteriServis = InstanceFactory.Get<IMusteriService>();
            personelServis = InstanceFactory.Get<IPersonelService>();
            faturaDetayServis = InstanceFactory.Get<IFaturaDetayService>();
            urunServis = InstanceFactory.Get<IUrunService>();
        }

        private void veritabaniBtns_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;
            switch (btn.Text)
            {
                case "Kaydet":
                    FaturaBilgiKaydet();
                    break;
                case "Güncelle":
                    FaturaBilgiGUncelle();
                    break;
                case "Sil":
                    FaturaBİlgiSil();
                    break;
                case "Temizle":
                    Temizle();
                    break;
            }
            BindDataFaturaBilgi();
            Temizle();
        }

        private void FaturaBİlgiSil()
        {
            if (faturaBilgiId != -1)
            {
                try
                {
                    faturaBilgiServis.Add(new Entities.Concrete.FaturaBilgi
                    {
                        Id = faturaBilgiId
                    });
                    MessageBox.Show("Fatura bilgisi başarıyla silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("İşlem yapılacak fatura bilgisini listeden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FaturaBilgiGUncelle()
        {
            if (faturaBilgiId != -1)
            {
                try
                {
                    faturaBilgiServis.Add(new Entities.Concrete.FaturaBilgi
                    {
                        Id = faturaBilgiId,
                        Seri = seriTxt.Text.ToString(),
                        SiraNo = siraTxt.Text.ToString(),
                        Tarih = DateTime.Parse(tarihDtPc.Value.ToString()),
                        Saat = saatTxt.Text.ToString(),
                        VergiDaire = vergiDairesiTxt.Text.ToString(),
                        MusteriId = int.Parse(musteriLook.EditValue.ToString()),
                        PersonelId = int.Parse(personelLook.EditValue.ToString())
                    });
                    MessageBox.Show("Fatura bilgisi başarıyla güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("İşlem yapılacak fatura bilgisini listeden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FaturaBilgiKaydet()
        {
            try
            {
                faturaBilgiServis.Add(new Entities.Concrete.FaturaBilgi
                {
                    Seri = seriTxt.Text.ToString(),
                    SiraNo = siraTxt.Text.ToString(),
                    Tarih = DateTime.Parse(tarihDtPc.Value.ToString()),
                    Saat = saatTxt.Text.ToString(),
                    VergiDaire = vergiDairesiTxt.Text.ToString(),
                    MusteriId = int.Parse(musteriLook.EditValue.ToString()),
                    PersonelId = int.Parse(personelLook.EditValue.ToString())
                });
                MessageBox.Show("Fatura bilgisi başarıyla eklendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindDataFaturaBilgi()
        {
            gridControl1.DataSource = from item in faturaBilgiServis.List()
                                      select new
                                      {
                                          item.Id,
                                          item.Seri,
                                          item.SiraNo,
                                          item.Tarih,
                                          item.Saat,
                                          item.VergiDaire,
                                          MusteriAdSoyad = item.Musteri.MusteriAd+" "+item.Musteri.MusteriSoyad,
                                          PersonelAdSoyad = item.Personel.PersonelAd+" "+item.Personel.PersonelSoyad
                                      };
        }

        private void Temizle()
        {
            faturaBilgiId = -1;
            faturaDetayId = -1;

            seriTxt.Text = "";
            siraTxt.Text = "";
            saatTxt.Text = "";
            vergiDairesiTxt.Text = "";

            musteriLook.Text = null;
            personelLook.Text = null;

            ////

            urunLook.Text = null;
            adetTxt.Text = "";
            fiyatTxt.Text = "";
            tutarTxt.Text = "";
            faturaIdTxt.Text = "";
        }

        private void FaturaForm_Load(object sender, EventArgs e)
        {
            musteriLook.Properties.DataSource = from item in musteriServis.List()
                                                select new
                                                {
                                                    item.Id,
                                                    AdSoyad = item.MusteriAd+" "+item.MusteriSoyad
                                                };
            personelLook.Properties.DataSource = from item in personelServis.List()
                                                 select new
                                                 {
                                                     item.Id,
                                                     AdSoyad = item.PersonelAd+" "+item.PersonelSoyad
                                                 };
            urunLook.Properties.DataSource = from item in urunServis.List()
                                             select new
                                             {
                                                 item.Id,
                                                 item.UrunAd
                                             };
            BindDataFaturaBilgi();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            faturaBilgiId = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            seriTxt.Text = gridView1.GetFocusedRowCellValue("Seri").ToString();
            siraTxt.Text = gridView1.GetFocusedRowCellValue("SiraNo").ToString();
            tarihDtPc.Value = DateTime.Parse(gridView1.GetFocusedRowCellValue("Tarih").ToString());
            saatTxt.Text = gridView1.GetFocusedRowCellValue("Saat").ToString();
            vergiDairesiTxt.Text = gridView1.GetFocusedRowCellValue("VergiDaire").ToString();
            musteriLook.Text = gridView1.GetFocusedRowCellValue("MusteriAdSoyad").ToString();
            personelLook.Text = gridView1.GetFocusedRowCellValue("PersonelAdSoyad").ToString();

            faturaIdTxt.Text = faturaBilgiId.ToString();

            gridControl2.DataSource = faturaDetayServis.List(c => c.Fatura.Id == faturaBilgiId);
        }

        private void detay_veritabani_Btns_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;
            switch (btn.Text)
            {
                case "Kaydet":
                    FaturaDetayKaydet();
                    break;
                case "Güncelle":
                    FaturaDetayGUncelle();
                    break;
                case "Sil":
                    FaturaDetaySil();
                    break;
                case "Temizle":
                    Temizle();
                    break;
            }
            Temizle();
        }

        private void FaturaDetaySil()
        {
            if (faturaDetayId != -1)
            {
                try
                {
                    faturaDetayServis.Delete(new Entities.Concrete.FaturaDetay
                    {
                        Id = faturaDetayId
                    });
                    MessageBox.Show("Fatura detayı silmesi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen işlem yapılacak fatura detay bilgisini listeden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FaturaDetayGUncelle()
        {
            if (faturaDetayId != -1)
            {
                try
                {
                    faturaDetayServis.Update(new Entities.Concrete.FaturaDetay
                    {
                        Id = faturaDetayId,
                        UrunAd = urunLook.Text.ToString(),
                        Adet = int.Parse(adetTxt.Text.ToString()),
                        Fiyat = decimal.Parse(fiyatTxt.Text.ToString()),
                        Tutar = decimal.Parse(tutarTxt.Text.ToString()),
                        FaturaId = int.Parse(faturaIdTxt.Text.ToString())
                    });
                    MessageBox.Show("Fatura detayı güncellemesi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen işlem yapılacak fatura detay bilgisini listeden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FaturaDetayKaydet()
        {
            try
            {
                faturaDetayServis.Add(new Entities.Concrete.FaturaDetay
                {
                    UrunAd = urunLook.Text.ToString(),
                    Adet = int.Parse(adetTxt.Text.ToString()),
                    Fiyat = decimal.Parse(fiyatTxt.Text.ToString()),
                    Tutar = decimal.Parse(tutarTxt.Text.ToString()),
                    FaturaId = int.Parse(faturaIdTxt.Text.ToString())
                });
                MessageBox.Show("Fatura detayı eklemesi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView2_Click(object sender, EventArgs e)
        {
            faturaDetayId = int.Parse(gridView2.GetFocusedRowCellValue("Id").ToString());
            urunLook.Text = gridView2.GetFocusedRowCellValue("UrunAd").ToString();
            adetTxt.Text = gridView2.GetFocusedRowCellValue("Adet").ToString();
            fiyatTxt.Text = gridView2.GetFocusedRowCellValue("Fiyat").ToString();
            tutarTxt.Text = gridView2.GetFocusedRowCellValue("Tutar").ToString();
        }
    }
}
