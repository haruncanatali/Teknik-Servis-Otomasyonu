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
    public partial class NotlarFom : Form
    {
        int id = -1;
        INotlarService notlarServis;
        public NotlarFom()
        {
            InitializeComponent();
            notlarServis = InstanceFactory.Get<INotlarService>();
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
                    notlarServis.Delete(new Entities.Concrete.Notlar
                    {
                        Id = id
                    });
                    MessageBox.Show("Not başarı ile silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silinecek notu listeden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Guncelle()
        {
            if (id != -1)
            {
                try
                {
                    notlarServis.Update(new Entities.Concrete.Notlar
                    {
                        Id = id,
                        Baslik = baslikTxt.Text.ToString(),
                        Icerik = icerikTxt.Text.ToString(),
                        Durum = durumChck.CheckState == CheckState.Checked ? true : false
                    });
                    MessageBox.Show("Not başarı ile güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Güncellenecek notu listeden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Kaydet()
        {
            try
            {
                notlarServis.Add(new Entities.Concrete.Notlar
                {
                    Baslik = baslikTxt.Text.ToString(),
                    Icerik = icerikTxt.Text.ToString(),
                    Durum = durumChck.CheckState == CheckState.Checked ? true : false
                });
                MessageBox.Show("Not başarı ile eklendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindData()
        {
            gridControl1.DataSource = from item in notlarServis.List()
                                      select new
                                      {
                                          item.Id,
                                          item.Baslik,
                                          item.Icerik,
                                          item.Durum
                                      };
        }

        private void Temizle()
        {
            id = -1;
            baslikTxt.Text = "";
            icerikTxt.Text = "";
            durumChck.CheckState = CheckState.Unchecked;
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            id = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            baslikTxt.Text = gridView1.GetFocusedRowCellValue("Baslik").ToString();
            icerikTxt.Text = gridView1.GetFocusedRowCellValue("Icerik").ToString();
            if (bool.Parse(gridView1.GetFocusedRowCellValue("Durum").ToString()))
            {
                durumChck.CheckState = CheckState.Checked;
            }
            else
            {
                durumChck.CheckState = CheckState.Unchecked;
            }
        }

        private void NotlarFom_Load(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
