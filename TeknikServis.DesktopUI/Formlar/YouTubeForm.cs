using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.DesktopUI.Raporlar
{
    public partial class YouTubeForm : Form
    {
        public YouTubeForm()
        {
            InitializeComponent();
        }

        private void YouTubeForm_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/?hl=tr&gl=TR");
        }
    }
}
