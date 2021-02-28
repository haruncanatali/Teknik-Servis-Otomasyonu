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
    public partial class DepartmanForm : Form
    {
        IDepartmanService departmanServis;
        int id = -1;
        public DepartmanForm()
        {
            InitializeComponent();
            departmanServis = InstanceFactory.Get<IDepartmanService>();
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
                    departmanServis.Delete(new Entities.Concrete.Departman
                    {
                        Id = id
                    });
                    MessageBox.Show("Departman silme başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silinecek departmanı listeden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Guncelle()
        {
            if (id!=-1)
            {
                try
                {
                    departmanServis.Update(new Entities.Concrete.Departman
                    {
                        Id = id,
                        DepartmanAd = dapartmanAdTxt.Text.ToString(),
                        DepartmanAciklama = departmanAciklamaTxt.Text.ToString()
                    });
                    MessageBox.Show("Departman güncelleme başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Güncellenecek departmanı listeden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Kaydet()
        {
            try
            {
                departmanServis.Add(new Entities.Concrete.Departman
                {
                    DepartmanAd = dapartmanAdTxt.Text.ToString(),
                    DepartmanAciklama = departmanAciklamaTxt.Text.ToString()
                });
                MessageBox.Show("Departman ekleme başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Temizle()
        {
            dapartmanAdTxt.Text = "";
            departmanAciklamaTxt.Text = "";
            id = -1;
        }

        private void DepartmanForm_Load(object sender, EventArgs e)
        {
            BindData();
        }
        private void BindData()
        {
            gridControl1.DataSource = from item in departmanServis.List()
                                      select new
                                      {
                                          item.Id,
                                          item.DepartmanAd,
                                          item.DepartmanAciklama
                                      };
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            id = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            dapartmanAdTxt.Text = gridView1.GetFocusedRowCellValue("DepartmanAd").ToString();
            departmanAciklamaTxt.Text = gridView1.GetFocusedRowCellValue("DepartmanAciklama").ToString();
        }
    }
}
