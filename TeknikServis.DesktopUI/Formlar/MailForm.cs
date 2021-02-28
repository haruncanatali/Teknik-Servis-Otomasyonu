using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.DesktopUI.Formlar
{
    public partial class MailForm : Form
    {
        public MailForm()
        {
            InitializeComponent();
        }

        private void gonderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mesaj = new MailMessage();
                SmtpClient alici = new SmtpClient();

                alici.Credentials = new System.Net.NetworkCredential(gonderenTxt.Text.ToString(), gondericiSifreTxt.Text.ToString());
                alici.Port = 587;
                alici.Host = "smtp.live.com";
                alici.EnableSsl = true;

                mesaj.To.Add(aliciTxt.Text.ToString());
                mesaj.From = new MailAddress(gonderenTxt.Text.ToString());
                mesaj.Subject = konuTxt.Text.ToString();
                mesaj.Body = mesajTxt.Text.ToString();

                alici.Send(mesaj);

                MessageBox.Show("Mesaj Başarı İle Gönderildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mesaj gönderme başarısız oldu.Hata:" + ex.Message);
            }
        }

        private void vazgecBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
