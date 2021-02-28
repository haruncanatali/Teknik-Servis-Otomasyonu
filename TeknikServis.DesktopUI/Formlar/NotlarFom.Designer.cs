
namespace TeknikServis.DesktopUI.Formlar
{
    partial class NotlarFom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotlarFom));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.durumChck = new DevExpress.XtraEditors.CheckEdit();
            this.baslikTxt = new DevExpress.XtraEditors.TextEdit();
            this.icerikTxt = new System.Windows.Forms.RichTextBox();
            this.kaydetBtn = new DevExpress.XtraEditors.SimpleButton();
            this.guncelleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.silBtn = new DevExpress.XtraEditors.SimpleButton();
            this.temizleBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durumChck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baslikTxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1049, 511);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.LightSalmon;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Yellow;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.silBtn);
            this.groupControl1.Controls.Add(this.guncelleBtn);
            this.groupControl1.Controls.Add(this.temizleBtn);
            this.groupControl1.Controls.Add(this.kaydetBtn);
            this.groupControl1.Controls.Add(this.icerikTxt);
            this.groupControl1.Controls.Add(this.baslikTxt);
            this.groupControl1.Controls.Add(this.durumChck);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(1049, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(301, 511);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Veritabanı İşlemleri";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Başlık :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(7, 98);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "İçerik :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(7, 339);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 18);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Durum :";
            // 
            // durumChck
            // 
            this.durumChck.Location = new System.Drawing.Point(71, 340);
            this.durumChck.Name = "durumChck";
            this.durumChck.Properties.Caption = "Okundu Olarak İşaretle";
            this.durumChck.Size = new System.Drawing.Size(137, 19);
            this.durumChck.TabIndex = 3;
            // 
            // baslikTxt
            // 
            this.baslikTxt.Location = new System.Drawing.Point(71, 56);
            this.baslikTxt.Name = "baslikTxt";
            this.baslikTxt.Properties.Appearance.Options.UseTextOptions = true;
            this.baslikTxt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.baslikTxt.Size = new System.Drawing.Size(218, 20);
            this.baslikTxt.TabIndex = 1;
            // 
            // icerikTxt
            // 
            this.icerikTxt.Location = new System.Drawing.Point(67, 99);
            this.icerikTxt.Name = "icerikTxt";
            this.icerikTxt.Size = new System.Drawing.Size(222, 218);
            this.icerikTxt.TabIndex = 2;
            this.icerikTxt.Text = "";
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("kaydetBtn.ImageOptions.Image")));
            this.kaydetBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.kaydetBtn.Location = new System.Drawing.Point(52, 389);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(75, 65);
            this.kaydetBtn.TabIndex = 4;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.Click += new System.EventHandler(this.veritabaniBtns_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("guncelleBtn.ImageOptions.Image")));
            this.guncelleBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.guncelleBtn.Location = new System.Drawing.Point(133, 389);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(75, 65);
            this.guncelleBtn.TabIndex = 4;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.Click += new System.EventHandler(this.veritabaniBtns_Click);
            // 
            // silBtn
            // 
            this.silBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("silBtn.ImageOptions.Image")));
            this.silBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.silBtn.Location = new System.Drawing.Point(214, 389);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(75, 65);
            this.silBtn.TabIndex = 4;
            this.silBtn.Text = "Sil";
            this.silBtn.Click += new System.EventHandler(this.veritabaniBtns_Click);
            // 
            // temizleBtn
            // 
            this.temizleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("temizleBtn.ImageOptions.Image")));
            this.temizleBtn.Location = new System.Drawing.Point(52, 458);
            this.temizleBtn.Name = "temizleBtn";
            this.temizleBtn.Size = new System.Drawing.Size(237, 34);
            this.temizleBtn.TabIndex = 4;
            this.temizleBtn.Text = "Temizle";
            this.temizleBtn.Click += new System.EventHandler(this.veritabaniBtns_Click);
            // 
            // NotlarFom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 511);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "NotlarFom";
            this.Text = "Notlar";
            this.Load += new System.EventHandler(this.NotlarFom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durumChck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baslikTxt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton silBtn;
        private DevExpress.XtraEditors.SimpleButton guncelleBtn;
        private DevExpress.XtraEditors.SimpleButton temizleBtn;
        private DevExpress.XtraEditors.SimpleButton kaydetBtn;
        private System.Windows.Forms.RichTextBox icerikTxt;
        private DevExpress.XtraEditors.TextEdit baslikTxt;
        private DevExpress.XtraEditors.CheckEdit durumChck;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}