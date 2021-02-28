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
    public partial class ArizaKaydiForm : Form
    {
        IUrunKabulService urunKabulServis;
        IMusteriService musteriServis;
        IPersonelService personelServis;
        IUrunService urunServis;
        IUrunHareketService urunHareketServis;

        public ArizaKaydiForm()
        {
            InitializeComponent();
            urunKabulServis = InstanceFactory.Get<IUrunKabulService>();
            urunServis = InstanceFactory.Get<IUrunService>();
            personelServis = InstanceFactory.Get<IPersonelService>();
            musteriServis = InstanceFactory.Get<IMusteriService>();
            urunHareketServis = InstanceFactory.Get<IUrunHareketService>();
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (urunHareketServis.Get(c=>c.SeriNo == seriTxt.Text.ToString()) != null)
                {
                    if (urunKabulServis.Get(c=>c.SeriNo == seriTxt.Text) != null)
                    {
                        MessageBox.Show("Ürün tamir edilmek üzere zaten sistemde kayıtlı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        urunKabulServis.Add(new Entities.Concrete.UrunKabul
                        {
                            GelisTarihi = DateTime.Parse(tarihDtPc.Value.ToString()),
                            UrunId = int.Parse(urunLook.EditValue.ToString()),
                            MusteriId = int.Parse(musteriLook.EditValue.ToString()),
                            PersonelId = int.Parse(personelLook.EditValue.ToString()),
                            SeriNo = seriTxt.Text.ToString(),
                            CikisTarihi = (DateTime.Parse(tarihDtPc.Value.ToString())).AddDays(15)
                        });
                        MessageBox.Show("Arızalı ürün kaydı başarılı oldu.", "Bİlgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Ürün Kaydı Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void vazgecBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ArizaKaydiForm_Load(object sender, EventArgs e)
        {
            urunLook.Properties.DataSource = from item in urunServis.List()
                                             select new
                                             {
                                                 item.Id,
                                                 item.UrunAd
                                             };
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
                                                     AdSoyad = item.PersonelAd + " " + item.PersonelSoyad
                                                 };
        }
    }
}
