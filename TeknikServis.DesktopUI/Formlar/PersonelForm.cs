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
    public partial class PersonelForm : Form
    {
        IPersonelService personelServis;
        IDepartmanService departmanServis;
        int id = -1;
        public PersonelForm()
        {
            InitializeComponent();
            personelServis = InstanceFactory.Get<IPersonelService>();
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

        private void Guncelle()
        {
            if (id!=-1)
            {
                try
                {
                    personelServis.Update(new Entities.Concrete.Personel
                    {
                        Id = id,
                        PersonelAd = adTxt.Text.ToString(),
                        PersonelSoyad = soyadTxt.Text.ToString(),
                        PersonelFotorafBaglantisi = fotoDosyaYolu.Text.ToString(),
                        PersonelMail = mailTxt.Text.ToString(),
                        PersonelTelefon = telefonTxt.Text.ToString(),
                        PersonelMaas = decimal.Parse(maasTxt.Text.ToString()),
                        DepartmanId = int.Parse(departmanLookUpEdit.Properties.ValueMember.ToString())
                    });
                    MessageBox.Show("Personel güncelleme başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Güncellenecek personeli listeden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sil()
        {
            if (id != -1)
            {
                try
                {
                    personelServis.Delete(new Entities.Concrete.Personel
                    {
                        Id = id
                    });
                    MessageBox.Show("Personel silme başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silinecek personeli listeden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Kaydet()
        {
            try
            {
                personelServis.Add(new Entities.Concrete.Personel
                {
                    PersonelAd = adTxt.Text.ToString(),
                    PersonelSoyad = soyadTxt.Text.ToString(),
                    PersonelFotorafBaglantisi = fotoDosyaYolu.Text.ToString(),
                    PersonelMail = maasTxt.Text.ToString(),
                    PersonelTelefon = telefonTxt.Text.ToString(),
                    PersonelMaas = decimal.Parse(maasTxt.Text.ToString()),
                    DepartmanId = int.Parse(departmanLookUpEdit.EditValue.ToString())
                });
                MessageBox.Show("Personel ekleme başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindData()
        {
            gridControl1.DataSource = from item in personelServis.List()
                                      select new
                                      {
                                          item.Id,
                                          item.PersonelAd,
                                          item.PersonelSoyad,
                                          item.PersonelFotorafBaglantisi,
                                          item.PersonelMail,
                                          item.PersonelTelefon,
                                          item.PersonelMaas,
                                          Departmani = item.Departman.DepartmanAd
                                      };
            departmanLookUpEdit.Properties.DataSource = from item in departmanServis.List()
                                                        select new
                                                        {
                                                            item.Id,
                                                            item.DepartmanAd
                                                        };
        }

        private void Temizle()
        {
            foreach (var item in groupControl1.Controls)
            {
                if (item is TextEdit)
                {
                    TextEdit txt = (TextEdit)item;
                    txt.Text = "";
                }
            }
            personelFotoPct.Image = null;
            departmanLookUpEdit.Text = null;
            id = -1;
        }

        private void fotoSecBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();

            fotoDosyaYolu.Text = fileDialog.FileName;
        }

        private void fotoDosyaYolu_TextChanged(object sender, EventArgs e)
        {
            if (fotoDosyaYolu.Text!="")
            {
                try
                {
                    personelFotoPct.Image = Image.FromFile(fotoDosyaYolu.Text);
                }
                catch (System.IO.FileNotFoundException ex)
                {
                    
                }
            }
        }

        private void PersonelForm_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            id = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            adTxt.Text = gridView1.GetFocusedRowCellValue("PersonelAd").ToString();
            soyadTxt.Text = gridView1.GetFocusedRowCellValue("PersonelSoyad").ToString();
            fotoDosyaYolu.Text = gridView1.GetFocusedRowCellValue("PersonelFotorafBaglantisi").ToString();
            mailTxt.Text = gridView1.GetFocusedRowCellValue("PersonelMail").ToString();
            telefonTxt.Text = gridView1.GetFocusedRowCellValue("PersonelTelefon").ToString();
            maasTxt.Text = gridView1.GetFocusedRowCellValue("PersonelMaas").ToString();
            departmanLookUpEdit.Text = gridView1.GetFocusedRowCellValue("Departmani").ToString();
        }
    }
}
