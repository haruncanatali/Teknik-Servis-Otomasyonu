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
    public partial class MusteriForm : Form
    {
        int id = -1;
        IMusteriService musteriServis;
        public MusteriForm()
        {
            InitializeComponent();
            musteriServis = InstanceFactory.Get<IMusteriService>();
        }

        private void veriTabaniBtns_Click(object sender, EventArgs e)
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

        private void BindData()
        {
            gridControl1.DataSource = from item in musteriServis.List()
                                      select new
                                      {
                                          item.Id,
                                          item.MusteriAd,
                                          item.MusteriSoyad,
                                          item.MusteriTelefon,
                                          item.MusteriMail,
                                          item.MusteriBanka,
                                          item.MusteriVergiDaire,
                                          item.MusteriVergiNo,
                                          item.MusteriStatu,
                                          item.MusteriIl,
                                          item.MusteriIlce,
                                          item.MusteriAcikAdres
                                      };
        }

        private void Sil()
        {
            if (id != -1)
            {
                try
                {
                    musteriServis.Delete(new Entities.Concrete.Musteri
                    {
                        Id = id,
                    });
                    MessageBox.Show("Müşteri silme işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silinecek müşteriyi listeden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Guncelle()
        {
            if (id !=-1)
            {
                try
                {
                    musteriServis.Update(new Entities.Concrete.Musteri
                    {
                        Id = id,
                        MusteriAd = adTxt.Text.ToString(),
                        MusteriSoyad = soyadTxt.Text.ToString(),
                        MusteriTelefon = telefonTxt.Text.ToString(),
                        MusteriMail = mailTxt.Text.ToString(),
                        MusteriBanka = bankaTxt.Text.ToString(),
                        MusteriVergiDaire = vergiDairesiTxt.Text.ToString(),
                        MusteriVergiNo = vergiNumarasiTxt.Text.ToString(),
                        MusteriStatu = statuTxt.Text.ToString(),
                        MusteriIl = ilTxt.Text.ToString(),
                        MusteriIlce = ilceTxt.Text.ToString(),
                        MusteriAcikAdres = acikAdresTxt.Text.ToString()
                    });
                    MessageBox.Show("Müşteri güncelleme işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Güncellenecek müşteriyi listeden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Kaydet()
        {
            try
            {
                musteriServis.Add(new Entities.Concrete.Musteri
                {
                    MusteriAd = adTxt.Text.ToString(),
                    MusteriSoyad = soyadTxt.Text.ToString(),
                    MusteriTelefon = telefonTxt.Text.ToString(),
                    MusteriMail = mailTxt.Text.ToString(),
                    MusteriBanka = bankaTxt.Text.ToString(),
                    MusteriVergiDaire = vergiDairesiTxt.Text.ToString(),
                    MusteriVergiNo = vergiNumarasiTxt.Text.ToString(),
                    MusteriStatu = statuTxt.Text.ToString(),
                    MusteriIl = ilTxt.Text.ToString(),
                    MusteriIlce = ilceTxt.Text.ToString(),
                    MusteriAcikAdres = acikAdresTxt.Text.ToString()
                });
                MessageBox.Show("Müşteri ekleme işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Temizle()
        {
            id = -1;
            foreach (var item in groupControl1.Controls)
            {
                if(item is TextEdit)
                {
                    TextEdit txt = (TextEdit)item;
                    txt.Text = "";
                }
            }
            acikAdresTxt.Text = "";

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            id = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            adTxt.Text = gridView1.GetFocusedRowCellValue("MusteriAd").ToString();
            soyadTxt.Text = gridView1.GetFocusedRowCellValue("MusteriSoyad").ToString();
            telefonTxt.Text = gridView1.GetFocusedRowCellValue("MusteriTelefon").ToString();
            mailTxt.Text = gridView1.GetFocusedRowCellValue("MusteriMail").ToString();
            bankaTxt.Text = gridView1.GetFocusedRowCellValue("MusteriBanka").ToString();
            vergiDairesiTxt.Text = gridView1.GetFocusedRowCellValue("MusteriVergiDaire").ToString();
            vergiNumarasiTxt.Text = gridView1.GetFocusedRowCellValue("MusteriVergiNo").ToString();
            statuTxt.Text = gridView1.GetFocusedRowCellValue("MusteriStatu").ToString();
            ilTxt.Text = gridView1.GetFocusedRowCellValue("MusteriIl").ToString();
            ilceTxt.Text = gridView1.GetFocusedRowCellValue("MusteriIlce").ToString();
            acikAdresTxt.Text = gridView1.GetFocusedRowCellValue("MusteriAcikAdres").ToString();
        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
