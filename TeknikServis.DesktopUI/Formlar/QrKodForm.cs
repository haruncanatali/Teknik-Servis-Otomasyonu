﻿using MessagingToolkit.QRCode.Codec;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.DesktopUI.Formlar
{
    public partial class QrKodForm : Form
    {
        public QrKodForm()
        {
            InitializeComponent();
        }

        private void olusturBtn_Click(object sender, EventArgs e)
        {
            QRCodeEncoder enkoder = new QRCodeEncoder();
            qrKodPc.Image = enkoder.Encode(seriNoTxt.Text.ToString());
        }

        private void vazgecBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
