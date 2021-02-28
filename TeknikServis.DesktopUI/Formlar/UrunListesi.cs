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
using TeknikServis.Entities.Concrete;

namespace TeknikServis.DesktopUI.Formlar
{
    public partial class UrunListesi : Form
    {
        IUrunService urunServis;
        IKategoriService kategoriServis;
        int id=-1;

        public UrunListesi()
        {
            InitializeComponent();
            kategoriServis = InstanceFactory.Get<IKategoriService>();
            urunServis = InstanceFactory.Get<IUrunService>();
        }

        private void UrunListesi_Load(object sender, EventArgs e)
        {
            kategoriLookUpTxt.Properties.DataSource = from item in kategoriServis.List()
                                                      select new
                                                      {
                                                          item.Id,
                                                          item.KategoriAd
                                                      };
            BindData();
        }
        private void BindData()
        {
            gridControl1.DataSource = from item in urunServis.List()
                                      select new
                                      {
                                          item.Id,
                                          item.UrunAd,
                                          item.UrunMarka,
                                          item.AlisFiyat,
                                          item.SatisFiyat,
                                          item.UrunStok,
                                          Kategori = item.Kategori.KategoriAd
                                      };
        }

        private void Temizle()
        {
            id = -1;
            urunAdTxt.Text = "";
            urunMarkaTxt.Text = "";
            alisFiyatTxt.Text = "";
            satisFiyatTxt.Text = "";
            urunStokTxt.Text = "";
            kategoriLookUpTxt.Text = "";
        }

        private void VeriTabaniBtns_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;
            switch (btn.Text)
            {
                case "Kaydet":
                    KaydetFonk();
                    break;
                case "Güncelle":
                    GuncelleFonk();
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
                    urunServis.Delete(new Urun
                    {
                        Id = id
                    });
                    MessageBox.Show("Ürün silme başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silinecek ürünü listeden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuncelleFonk()
        {
            try
            {
                urunServis.Update(new Urun
                {
                    Id = id,
                    UrunAd = urunAdTxt.Text.ToString(),
                    UrunMarka = urunMarkaTxt.Text.ToString(),
                    AlisFiyat = decimal.Parse(alisFiyatTxt.Text.ToString()),
                    SatisFiyat = decimal.Parse(satisFiyatTxt.Text.ToString()),
                    UrunStok = int.Parse(urunStokTxt.Text.ToString()),
                    UrunDurum = false,
                    KategoriId = int.Parse(kategoriLookUpTxt.EditValue.ToString())
                });
                MessageBox.Show("Ürün güncelleme başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void KaydetFonk()
        {
            try
            {
                urunServis.Add(new Urun
                {
                    UrunAd = urunAdTxt.Text.ToString(),
                    UrunMarka = urunMarkaTxt.Text.ToString(),
                    AlisFiyat = decimal.Parse(alisFiyatTxt.Text.ToString()),
                    SatisFiyat = decimal.Parse(satisFiyatTxt.Text.ToString()),
                    UrunStok = int.Parse(urunStokTxt.Text.ToString()),
                    UrunDurum = false,
                    KategoriId = int.Parse(kategoriLookUpTxt.EditValue.ToString()),
                });
                MessageBox.Show("Ürün ekleme başarılı oldu.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            id = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            urunAdTxt.Text = gridView1.GetFocusedRowCellValue("UrunAd").ToString();
            urunMarkaTxt.Text = gridView1.GetFocusedRowCellValue("UrunMarka").ToString();
            alisFiyatTxt.Text = gridView1.GetFocusedRowCellValue("AlisFiyat").ToString();
            satisFiyatTxt.Text = gridView1.GetFocusedRowCellValue("SatisFiyat").ToString();
            urunStokTxt.Text = gridView1.GetFocusedRowCellValue("UrunStok").ToString();
            kategoriLookUpTxt.Text = gridView1.GetFocusedRowCellValue("Kategori").ToString();
        }
    }
}
