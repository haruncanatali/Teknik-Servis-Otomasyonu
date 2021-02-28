
namespace TeknikServis.DesktopUI.Formlar
{
    partial class SatisEkleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatisEkleForm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.urunLook = new DevExpress.XtraEditors.LookUpEdit();
            this.personelLook = new DevExpress.XtraEditors.LookUpEdit();
            this.musteriLook = new DevExpress.XtraEditors.LookUpEdit();
            this.fiyatTxt = new DevExpress.XtraEditors.TextEdit();
            this.adetTxt = new DevExpress.XtraEditors.TextEdit();
            this.seriNoTxt = new DevExpress.XtraEditors.TextEdit();
            this.tarihDateTimePic = new System.Windows.Forms.DateTimePicker();
            this.kaydetBtn = new DevExpress.XtraEditors.SimpleButton();
            this.guncelleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.silBtn = new DevExpress.XtraEditors.SimpleButton();
            this.temizleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.IdCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UrunAdCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MusteriAdCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PersonelAdCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SeriNoCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FiyatCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AdetCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TarihCol = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunLook.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelLook.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriLook.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiyatTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adetTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriNoTxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1006, 511);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Red;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdCol,
            this.UrunAdCol,
            this.MusteriAdCol,
            this.PersonelAdCol,
            this.SeriNoCol,
            this.FiyatCol,
            this.AdetCol,
            this.TarihCol});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.silBtn);
            this.groupControl1.Controls.Add(this.temizleBtn);
            this.groupControl1.Controls.Add(this.guncelleBtn);
            this.groupControl1.Controls.Add(this.kaydetBtn);
            this.groupControl1.Controls.Add(this.tarihDateTimePic);
            this.groupControl1.Controls.Add(this.seriNoTxt);
            this.groupControl1.Controls.Add(this.adetTxt);
            this.groupControl1.Controls.Add(this.fiyatTxt);
            this.groupControl1.Controls.Add(this.musteriLook);
            this.groupControl1.Controls.Add(this.personelLook);
            this.groupControl1.Controls.Add(this.urunLook);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(1006, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(344, 511);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Veritabanı İşlemleri";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(76, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ürün :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(46, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Personel :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(55, 108);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 18);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Müşteri :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(74, 137);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 18);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Fiyat :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(78, 167);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(43, 18);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Adet :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(73, 197);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 18);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Tarih :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(5, 228);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(116, 18);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Seri Numarası :";
            // 
            // urunLook
            // 
            this.urunLook.Location = new System.Drawing.Point(127, 51);
            this.urunLook.Name = "urunLook";
            this.urunLook.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.urunLook.Properties.DisplayMember = "UrunAd";
            this.urunLook.Properties.ValueMember = "Id";
            this.urunLook.Size = new System.Drawing.Size(205, 20);
            this.urunLook.TabIndex = 1;
            // 
            // personelLook
            // 
            this.personelLook.Location = new System.Drawing.Point(127, 80);
            this.personelLook.Name = "personelLook";
            this.personelLook.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.personelLook.Properties.DisplayMember = "AdSoyad";
            this.personelLook.Properties.ValueMember = "Id";
            this.personelLook.Size = new System.Drawing.Size(205, 20);
            this.personelLook.TabIndex = 2;
            // 
            // musteriLook
            // 
            this.musteriLook.Location = new System.Drawing.Point(127, 109);
            this.musteriLook.Name = "musteriLook";
            this.musteriLook.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.musteriLook.Properties.DisplayMember = "AdSoyad";
            this.musteriLook.Properties.ValueMember = "Id";
            this.musteriLook.Size = new System.Drawing.Size(205, 20);
            this.musteriLook.TabIndex = 3;
            // 
            // fiyatTxt
            // 
            this.fiyatTxt.Location = new System.Drawing.Point(127, 138);
            this.fiyatTxt.Name = "fiyatTxt";
            this.fiyatTxt.Size = new System.Drawing.Size(205, 20);
            this.fiyatTxt.TabIndex = 4;
            // 
            // adetTxt
            // 
            this.adetTxt.Location = new System.Drawing.Point(127, 168);
            this.adetTxt.Name = "adetTxt";
            this.adetTxt.Size = new System.Drawing.Size(205, 20);
            this.adetTxt.TabIndex = 5;
            // 
            // seriNoTxt
            // 
            this.seriNoTxt.Location = new System.Drawing.Point(127, 229);
            this.seriNoTxt.Name = "seriNoTxt";
            this.seriNoTxt.Size = new System.Drawing.Size(205, 20);
            this.seriNoTxt.TabIndex = 7;
            // 
            // tarihDateTimePic
            // 
            this.tarihDateTimePic.Location = new System.Drawing.Point(127, 197);
            this.tarihDateTimePic.Name = "tarihDateTimePic";
            this.tarihDateTimePic.Size = new System.Drawing.Size(205, 21);
            this.tarihDateTimePic.TabIndex = 6;
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("kaydetBtn.ImageOptions.Image")));
            this.kaydetBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.kaydetBtn.Location = new System.Drawing.Point(94, 317);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(75, 70);
            this.kaydetBtn.TabIndex = 4;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.Click += new System.EventHandler(this.veritabaniBtns_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("guncelleBtn.ImageOptions.Image")));
            this.guncelleBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.guncelleBtn.Location = new System.Drawing.Point(175, 317);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(75, 70);
            this.guncelleBtn.TabIndex = 4;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.Click += new System.EventHandler(this.veritabaniBtns_Click);
            // 
            // silBtn
            // 
            this.silBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("silBtn.ImageOptions.Image")));
            this.silBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.silBtn.Location = new System.Drawing.Point(256, 317);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(75, 70);
            this.silBtn.TabIndex = 4;
            this.silBtn.Text = "Sil";
            this.silBtn.Click += new System.EventHandler(this.veritabaniBtns_Click);
            // 
            // temizleBtn
            // 
            this.temizleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("temizleBtn.ImageOptions.Image")));
            this.temizleBtn.Location = new System.Drawing.Point(94, 393);
            this.temizleBtn.Name = "temizleBtn";
            this.temizleBtn.Size = new System.Drawing.Size(237, 38);
            this.temizleBtn.TabIndex = 4;
            this.temizleBtn.Text = "Temizle";
            this.temizleBtn.Click += new System.EventHandler(this.veritabaniBtns_Click);
            // 
            // IdCol
            // 
            this.IdCol.Caption = "Id";
            this.IdCol.FieldName = "Id";
            this.IdCol.Name = "IdCol";
            // 
            // UrunAdCol
            // 
            this.UrunAdCol.Caption = "Ürün Adı";
            this.UrunAdCol.FieldName = "UrunAd";
            this.UrunAdCol.Name = "UrunAdCol";
            this.UrunAdCol.Visible = true;
            this.UrunAdCol.VisibleIndex = 0;
            // 
            // MusteriAdCol
            // 
            this.MusteriAdCol.Caption = "Müşteri Adı";
            this.MusteriAdCol.FieldName = "MusteriAd";
            this.MusteriAdCol.Name = "MusteriAdCol";
            this.MusteriAdCol.Visible = true;
            this.MusteriAdCol.VisibleIndex = 1;
            // 
            // PersonelAdCol
            // 
            this.PersonelAdCol.Caption = "Personel Adı";
            this.PersonelAdCol.FieldName = "PersonelAd";
            this.PersonelAdCol.Name = "PersonelAdCol";
            this.PersonelAdCol.Visible = true;
            this.PersonelAdCol.VisibleIndex = 2;
            // 
            // SeriNoCol
            // 
            this.SeriNoCol.Caption = "Seri Numarası";
            this.SeriNoCol.FieldName = "SeriNo";
            this.SeriNoCol.Name = "SeriNoCol";
            this.SeriNoCol.Visible = true;
            this.SeriNoCol.VisibleIndex = 3;
            // 
            // FiyatCol
            // 
            this.FiyatCol.Caption = "Fiyat";
            this.FiyatCol.FieldName = "Fiyat";
            this.FiyatCol.Name = "FiyatCol";
            this.FiyatCol.Visible = true;
            this.FiyatCol.VisibleIndex = 4;
            // 
            // AdetCol
            // 
            this.AdetCol.Caption = "Adet";
            this.AdetCol.FieldName = "Adet";
            this.AdetCol.Name = "AdetCol";
            this.AdetCol.Visible = true;
            this.AdetCol.VisibleIndex = 5;
            // 
            // TarihCol
            // 
            this.TarihCol.Caption = "Tarih";
            this.TarihCol.FieldName = "Tarih";
            this.TarihCol.Name = "TarihCol";
            this.TarihCol.Visible = true;
            this.TarihCol.VisibleIndex = 6;
            // 
            // SatisEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 511);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "SatisEkleForm";
            this.Text = "Satış İşlemi";
            this.Load += new System.EventHandler(this.SatisEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunLook.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelLook.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriLook.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiyatTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adetTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriNoTxt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton silBtn;
        private DevExpress.XtraEditors.SimpleButton temizleBtn;
        private DevExpress.XtraEditors.SimpleButton guncelleBtn;
        private DevExpress.XtraEditors.SimpleButton kaydetBtn;
        private System.Windows.Forms.DateTimePicker tarihDateTimePic;
        private DevExpress.XtraEditors.TextEdit seriNoTxt;
        private DevExpress.XtraEditors.TextEdit adetTxt;
        private DevExpress.XtraEditors.TextEdit fiyatTxt;
        private DevExpress.XtraEditors.LookUpEdit musteriLook;
        private DevExpress.XtraEditors.LookUpEdit personelLook;
        private DevExpress.XtraEditors.LookUpEdit urunLook;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn IdCol;
        private DevExpress.XtraGrid.Columns.GridColumn UrunAdCol;
        private DevExpress.XtraGrid.Columns.GridColumn MusteriAdCol;
        private DevExpress.XtraGrid.Columns.GridColumn PersonelAdCol;
        private DevExpress.XtraGrid.Columns.GridColumn SeriNoCol;
        private DevExpress.XtraGrid.Columns.GridColumn FiyatCol;
        private DevExpress.XtraGrid.Columns.GridColumn AdetCol;
        private DevExpress.XtraGrid.Columns.GridColumn TarihCol;
    }
}