
namespace TeknikServis.DesktopUI.Formlar
{
    partial class ArizaDetayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArizaDetayForm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.urunAdLook = new DevExpress.XtraEditors.LookUpEdit();
            this.tarihDtPc = new System.Windows.Forms.DateTimePicker();
            this.takipKoduTxt = new DevExpress.XtraEditors.TextEdit();
            this.KaydetBtn = new DevExpress.XtraEditors.SimpleButton();
            this.GuncelleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SilBtn = new DevExpress.XtraEditors.SimpleButton();
            this.TemizleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.IdCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TarihCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TakipKoduCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DurumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.durumTxt = new System.Windows.Forms.RichTextBox();
            this.UrunAdCol = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunAdLook.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takipKoduTxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(965, 511);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Lime;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdCol,
            this.UrunAdCol,
            this.TarihCol,
            this.TakipKoduCol,
            this.DurumCol});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.durumTxt);
            this.groupControl1.Controls.Add(this.SilBtn);
            this.groupControl1.Controls.Add(this.GuncelleBtn);
            this.groupControl1.Controls.Add(this.TemizleBtn);
            this.groupControl1.Controls.Add(this.KaydetBtn);
            this.groupControl1.Controls.Add(this.takipKoduTxt);
            this.groupControl1.Controls.Add(this.tarihDtPc);
            this.groupControl1.Controls.Add(this.urunAdLook);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(964, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(386, 511);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Veritabanı İşlemleri";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(27, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ürün Adı :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(53, 96);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tarih :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(8, 143);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(95, 18);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Takip Kodu :";
            // 
            // urunAdLook
            // 
            this.urunAdLook.Location = new System.Drawing.Point(107, 49);
            this.urunAdLook.Name = "urunAdLook";
            this.urunAdLook.Properties.Appearance.Options.UseTextOptions = true;
            this.urunAdLook.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.urunAdLook.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.urunAdLook.Properties.DisplayMember = "UrunAd";
            this.urunAdLook.Properties.ValueMember = "Id";
            this.urunAdLook.Size = new System.Drawing.Size(266, 20);
            this.urunAdLook.TabIndex = 1;
            // 
            // tarihDtPc
            // 
            this.tarihDtPc.Location = new System.Drawing.Point(107, 94);
            this.tarihDtPc.Name = "tarihDtPc";
            this.tarihDtPc.Size = new System.Drawing.Size(266, 21);
            this.tarihDtPc.TabIndex = 2;
            // 
            // takipKoduTxt
            // 
            this.takipKoduTxt.Location = new System.Drawing.Point(107, 144);
            this.takipKoduTxt.Name = "takipKoduTxt";
            this.takipKoduTxt.Properties.Appearance.Options.UseTextOptions = true;
            this.takipKoduTxt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.takipKoduTxt.Size = new System.Drawing.Size(266, 20);
            this.takipKoduTxt.TabIndex = 3;
            // 
            // KaydetBtn
            // 
            this.KaydetBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("KaydetBtn.ImageOptions.Image")));
            this.KaydetBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.KaydetBtn.Location = new System.Drawing.Point(124, 383);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(75, 73);
            this.KaydetBtn.TabIndex = 5;
            this.KaydetBtn.Text = "Kaydet";
            this.KaydetBtn.Click += new System.EventHandler(this.veritabaniBtns_Click);
            // 
            // GuncelleBtn
            // 
            this.GuncelleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("GuncelleBtn.ImageOptions.Image")));
            this.GuncelleBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.GuncelleBtn.Location = new System.Drawing.Point(205, 383);
            this.GuncelleBtn.Name = "GuncelleBtn";
            this.GuncelleBtn.Size = new System.Drawing.Size(75, 73);
            this.GuncelleBtn.TabIndex = 5;
            this.GuncelleBtn.Text = "Güncelle";
            this.GuncelleBtn.Click += new System.EventHandler(this.veritabaniBtns_Click);
            // 
            // SilBtn
            // 
            this.SilBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SilBtn.ImageOptions.Image")));
            this.SilBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.SilBtn.Location = new System.Drawing.Point(286, 383);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(75, 73);
            this.SilBtn.TabIndex = 5;
            this.SilBtn.Text = "Sil";
            this.SilBtn.Click += new System.EventHandler(this.veritabaniBtns_Click);
            // 
            // TemizleBtn
            // 
            this.TemizleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TemizleBtn.ImageOptions.Image")));
            this.TemizleBtn.Location = new System.Drawing.Point(124, 462);
            this.TemizleBtn.Name = "TemizleBtn";
            this.TemizleBtn.Size = new System.Drawing.Size(237, 37);
            this.TemizleBtn.TabIndex = 5;
            this.TemizleBtn.Text = "Temizle";
            this.TemizleBtn.Click += new System.EventHandler(this.veritabaniBtns_Click);
            // 
            // IdCol
            // 
            this.IdCol.Caption = "Id";
            this.IdCol.FieldName = "Id";
            this.IdCol.Name = "IdCol";
            // 
            // TarihCol
            // 
            this.TarihCol.Caption = "Güncelleme Tarihi";
            this.TarihCol.FieldName = "Tarih";
            this.TarihCol.Name = "TarihCol";
            this.TarihCol.Visible = true;
            this.TarihCol.VisibleIndex = 0;
            // 
            // TakipKoduCol
            // 
            this.TakipKoduCol.Caption = "Takip Kodu";
            this.TakipKoduCol.FieldName = "TakipKodu";
            this.TakipKoduCol.Name = "TakipKoduCol";
            this.TakipKoduCol.Visible = true;
            this.TakipKoduCol.VisibleIndex = 1;
            // 
            // DurumCol
            // 
            this.DurumCol.Caption = "Açıklama";
            this.DurumCol.FieldName = "Durum";
            this.DurumCol.Name = "DurumCol";
            this.DurumCol.Visible = true;
            this.DurumCol.VisibleIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(23, 183);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(78, 18);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Açıklama :";
            // 
            // durumTxt
            // 
            this.durumTxt.Location = new System.Drawing.Point(107, 184);
            this.durumTxt.Name = "durumTxt";
            this.durumTxt.Size = new System.Drawing.Size(264, 177);
            this.durumTxt.TabIndex = 6;
            this.durumTxt.Text = "";
            // 
            // UrunAdCol
            // 
            this.UrunAdCol.Caption = "Ürün Adı";
            this.UrunAdCol.FieldName = "UrunAd";
            this.UrunAdCol.Name = "UrunAdCol";
            this.UrunAdCol.Visible = true;
            this.UrunAdCol.VisibleIndex = 3;
            // 
            // ArizaDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 511);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "ArizaDetayForm";
            this.Text = "Arıza Detay Formu";
            this.Load += new System.EventHandler(this.ArizaDetayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunAdLook.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takipKoduTxt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn IdCol;
        private DevExpress.XtraGrid.Columns.GridColumn TarihCol;
        private DevExpress.XtraGrid.Columns.GridColumn TakipKoduCol;
        private DevExpress.XtraGrid.Columns.GridColumn DurumCol;
        private System.Windows.Forms.RichTextBox durumTxt;
        private DevExpress.XtraEditors.SimpleButton SilBtn;
        private DevExpress.XtraEditors.SimpleButton GuncelleBtn;
        private DevExpress.XtraEditors.SimpleButton TemizleBtn;
        private DevExpress.XtraEditors.SimpleButton KaydetBtn;
        private DevExpress.XtraEditors.TextEdit takipKoduTxt;
        private System.Windows.Forms.DateTimePicker tarihDtPc;
        private DevExpress.XtraEditors.LookUpEdit urunAdLook;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn UrunAdCol;
    }
}