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
    public partial class Kategori : Form
    {
        int id = -1;
        IKategoriService kategoriServis;
        public Kategori()
        {
            InitializeComponent();
        }

        private void BindData()
        {
            kategoriServis = InstanceFactory.Get<IKategoriService>();
            var degerler = from item in kategoriServis.List()
                                      select new
                                      {
                                          item.Id,
                                          item.KategoriAd,
                                      };
            gridControl1.DataSource = degerler;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
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

        private void Temizle()
        {
            id = -1;
            kategoriIdTxt.Text = "";
            kategoriAdTxt.Text = "";
        }

        private void Sil()
        {
            if (id != -1)
            {
                try
                {
                    kategoriServis.Delete(new Entities.Concrete.Kategori
                    {
                        Id = id
                    });

                    MessageBox.Show("Kategori silme başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silinecek kategoriyi listeden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuncelleFonk()
        {
            try
            {
                kategoriServis.Update(new Entities.Concrete.Kategori
                {
                    Id = id,
                    KategoriAd = kategoriAdTxt.Text.ToString()
                });
                MessageBox.Show("Kategori güncelleme başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                kategoriServis.Add(new Entities.Concrete.Kategori
                {
                    KategoriAd = kategoriAdTxt.Text.ToString()
                });
                MessageBox.Show("Kategori ekleme başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Kategori_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            id = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            kategoriIdTxt.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            kategoriAdTxt.Text = gridView1.GetFocusedRowCellValue("KategoriAd").ToString();
        }
    }
}
