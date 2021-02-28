
namespace TeknikServis.DesktopUI.Formlar
{
    partial class QrKodForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QrKodForm));
            this.qrKodPc = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.seriNoTxt = new DevExpress.XtraEditors.TextEdit();
            this.olusturBtn = new DevExpress.XtraEditors.SimpleButton();
            this.vazgecBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.qrKodPc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriNoTxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // qrKodPc
            // 
            this.qrKodPc.Location = new System.Drawing.Point(82, 57);
            this.qrKodPc.Name = "qrKodPc";
            this.qrKodPc.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.qrKodPc.Size = new System.Drawing.Size(165, 192);
            this.qrKodPc.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(9, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(285, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Seri Numarası İçin QR Kod Oluşturucu";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 285);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(116, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Seri Numarası :";
            // 
            // seriNoTxt
            // 
            this.seriNoTxt.Location = new System.Drawing.Point(134, 286);
            this.seriNoTxt.Name = "seriNoTxt";
            this.seriNoTxt.Size = new System.Drawing.Size(160, 20);
            this.seriNoTxt.TabIndex = 2;
            // 
            // olusturBtn
            // 
            this.olusturBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("olusturBtn.ImageOptions.Image")));
            this.olusturBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.olusturBtn.Location = new System.Drawing.Point(134, 322);
            this.olusturBtn.Name = "olusturBtn";
            this.olusturBtn.Size = new System.Drawing.Size(75, 62);
            this.olusturBtn.TabIndex = 3;
            this.olusturBtn.Text = "Oluştur";
            this.olusturBtn.Click += new System.EventHandler(this.olusturBtn_Click);
            // 
            // vazgecBtn
            // 
            this.vazgecBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("vazgecBtn.ImageOptions.Image")));
            this.vazgecBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.vazgecBtn.Location = new System.Drawing.Point(215, 322);
            this.vazgecBtn.Name = "vazgecBtn";
            this.vazgecBtn.Size = new System.Drawing.Size(75, 62);
            this.vazgecBtn.TabIndex = 3;
            this.vazgecBtn.Text = "Vazgeç";
            this.vazgecBtn.Click += new System.EventHandler(this.vazgecBtn_Click);
            // 
            // QrKodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 396);
            this.Controls.Add(this.vazgecBtn);
            this.Controls.Add(this.olusturBtn);
            this.Controls.Add(this.seriNoTxt);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.qrKodPc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QrKodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QrKodForm";
            ((System.ComponentModel.ISupportInitialize)(this.qrKodPc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriNoTxt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit qrKodPc;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit seriNoTxt;
        private DevExpress.XtraEditors.SimpleButton olusturBtn;
        private DevExpress.XtraEditors.SimpleButton vazgecBtn;
    }
}