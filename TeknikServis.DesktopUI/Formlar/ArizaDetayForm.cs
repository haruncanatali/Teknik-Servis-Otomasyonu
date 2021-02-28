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
    public partial class ArizaDetayForm : Form
    {
        IUrunTakipService urunTakipServis;
        IUrunKabulService urunKabulServis;
        IUrunService urunServis;
        int id = -1;

        public ArizaDetayForm()
        {
            InitializeComponent();
            urunTakipServis = InstanceFactory.Get<IUrunTakipService>();
            urunKabulServis = InstanceFactory.Get<IUrunKabulService>();
            urunServis = InstanceFactory.Get<IUrunService>();
        }

        private void ArizaDetayForm_Load(object sender, EventArgs e)
        {
            urunAdLook.Properties.DataSource = from item in urunServis.List()
                                               select new
                                               {
                                                   item.Id,
                                                   item.UrunAd
                                               };
            BindData();
        }

        private void BindData()
        {
            gridControl1.DataSource = from item in urunTakipServis.List()
                                      select new
                                      {
                                          item.Id,
                                          UrunAd = urunServis.Get(c=>c.Id == item.UrunId).UrunAd,
                                          item.Tarih,
                                          item.TakipKodu,
                                          item.Durum
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

        private void Temizle()
        {
            id = -1;
            urunAdLook.Text = null;
            takipKoduTxt.Text = "";
            durumTxt.Text = "";
        }
        private void Kaydet()
        {
            try
            {
                urunTakipServis.Add(new Entities.Concrete.UrunTakip
                {
                    TakipKodu = takipKoduTxt.Text.ToString(),
                    Durum = durumTxt.Text.ToString(),
                    Tarih = DateTime.Parse(tarihDtPc.Value.ToString()),
                    UrunId = int.Parse(urunServis.Get(c=>c.UrunAd == (urunAdLook.Text).ToString()).Id.ToString())
                });
                MessageBox.Show("Arıza detay ekleme işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arıza detay ekleme işlemi başarısız oldu.Hata:"+ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Guncelle()
        {
            if (id!=-1)
            {
                try
                {
                    urunTakipServis.Update(new Entities.Concrete.UrunTakip
                    {
                        Id = id,
                        TakipKodu = takipKoduTxt.Text.ToString(),
                        Durum = durumTxt.Text.ToString(),
                        Tarih = DateTime.Parse(tarihDtPc.Value.ToString()),
                        UrunId = int.Parse(urunServis.Get(c => c.UrunAd == (urunAdLook.Text).ToString()).Id.ToString())

                    });
                    MessageBox.Show("Arıza detay güncelleme işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Arıza detay güncelleme işlemi başarısız oldu.Hata:" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("İşlem yapılacak arıza detay bilgisini listeden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Sil()
        {
            if (id != -1)
            {
                try
                {
                    urunTakipServis.Delete(new Entities.Concrete.UrunTakip
                    {
                        Id = id
                    });
                    MessageBox.Show("Arıza detay silme işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Arıza detay silme işlemi başarısız oldu.Hata:" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("İşlem yapılacak arıza detay bilgisini listeden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            id = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            tarihDtPc.Value = DateTime.Parse(gridView1.GetFocusedRowCellValue("Tarih").ToString());
            takipKoduTxt.Text = gridView1.GetFocusedRowCellValue("TakipKodu").ToString();
            durumTxt.Text = gridView1.GetFocusedRowCellValue("Durum").ToString();
            urunAdLook.Text = gridView1.GetFocusedRowCellValue("UrunAd").ToString();
        }
    }
}
