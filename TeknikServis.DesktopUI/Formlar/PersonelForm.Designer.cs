
namespace TeknikServis.DesktopUI.Formlar
{
    partial class PersonelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelForm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.personelAdCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.personelSoyadCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.personelFotoCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.personelMailCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.personelTelefonCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.personelMaasCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.departmanCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.fotoDosyaYolu = new DevExpress.XtraEditors.TextEdit();
            this.fotoSecBtn = new DevExpress.XtraEditors.SimpleButton();
            this.silBtn = new DevExpress.XtraEditors.SimpleButton();
            this.guncelleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.temizleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.kaydetBtn = new DevExpress.XtraEditors.SimpleButton();
            this.departmanLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.maasTxt = new DevExpress.XtraEditors.TextEdit();
            this.telefonTxt = new DevExpress.XtraEditors.TextEdit();
            this.mailTxt = new DevExpress.XtraEditors.TextEdit();
            this.soyadTxt = new DevExpress.XtraEditors.TextEdit();
            this.adTxt = new DevExpress.XtraEditors.TextEdit();
            this.personelFotoPct = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.departmanlbl = new DevExpress.XtraEditors.LabelControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoDosyaYolu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maasTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyadTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelFotoPct.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1003, 511);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdCol,
            this.personelAdCol,
            this.personelSoyadCol,
            this.personelFotoCol,
            this.personelMailCol,
            this.personelTelefonCol,
            this.personelMaasCol,
            this.departmanCol});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // IdCol
            // 
            this.IdCol.Caption = "Id";
            this.IdCol.FieldName = "Id";
            this.IdCol.Name = "IdCol";
            // 
            // personelAdCol
            // 
            this.personelAdCol.Caption = "Personel Adı";
            this.personelAdCol.FieldName = "PersonelAd";
            this.personelAdCol.Name = "personelAdCol";
            this.personelAdCol.Visible = true;
            this.personelAdCol.VisibleIndex = 0;
            // 
            // personelSoyadCol
            // 
            this.personelSoyadCol.Caption = "Personel Soyadı";
            this.personelSoyadCol.FieldName = "PersonelSoyad";
            this.personelSoyadCol.Name = "personelSoyadCol";
            this.personelSoyadCol.Visible = true;
            this.personelSoyadCol.VisibleIndex = 1;
            // 
            // personelFotoCol
            // 
            this.personelFotoCol.Caption = "Personel Fotoğrafı";
            this.personelFotoCol.FieldName = "PersonelFotorafBaglantisi";
            this.personelFotoCol.Name = "personelFotoCol";
            // 
            // personelMailCol
            // 
            this.personelMailCol.Caption = "Personel Mail";
            this.personelMailCol.FieldName = "PersonelMail";
            this.personelMailCol.Name = "personelMailCol";
            this.personelMailCol.Visible = true;
            this.personelMailCol.VisibleIndex = 2;
            // 
            // personelTelefonCol
            // 
            this.personelTelefonCol.Caption = "Personel Telefonu";
            this.personelTelefonCol.FieldName = "PersonelTelefon";
            this.personelTelefonCol.Name = "personelTelefonCol";
            this.personelTelefonCol.Visible = true;
            this.personelTelefonCol.VisibleIndex = 3;
            // 
            // personelMaasCol
            // 
            this.personelMaasCol.Caption = "Personel Maaşı";
            this.personelMaasCol.FieldName = "PersonelMaas";
            this.personelMaasCol.Name = "personelMaasCol";
            this.personelMaasCol.Visible = true;
            this.personelMaasCol.VisibleIndex = 4;
            // 
            // departmanCol
            // 
            this.departmanCol.Caption = "Departmanı";
            this.departmanCol.FieldName = "Departmani";
            this.departmanCol.Name = "departmanCol";
            this.departmanCol.Visible = true;
            this.departmanCol.VisibleIndex = 5;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.fotoDosyaYolu);
            this.groupControl1.Controls.Add(this.fotoSecBtn);
            this.groupControl1.Controls.Add(this.silBtn);
            this.groupControl1.Controls.Add(this.guncelleBtn);
            this.groupControl1.Controls.Add(this.temizleBtn);
            this.groupControl1.Controls.Add(this.kaydetBtn);
            this.groupControl1.Controls.Add(this.departmanLookUpEdit);
            this.groupControl1.Controls.Add(this.maasTxt);
            this.groupControl1.Controls.Add(this.telefonTxt);
            this.groupControl1.Controls.Add(this.mailTxt);
            this.groupControl1.Controls.Add(this.soyadTxt);
            this.groupControl1.Controls.Add(this.adTxt);
            this.groupControl1.Controls.Add(this.personelFotoPct);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.departmanlbl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(1003, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(347, 511);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Veritabanı İşlemleri";
            // 
            // fotoDosyaYolu
            // 
            this.fotoDosyaYolu.Location = new System.Drawing.Point(189, 324);
            this.fotoDosyaYolu.Name = "fotoDosyaYolu";
            this.fotoDosyaYolu.Size = new System.Drawing.Size(146, 20);
            this.fotoDosyaYolu.TabIndex = 18;
            this.fotoDosyaYolu.TextChanged += new System.EventHandler(this.fotoDosyaYolu_TextChanged);
            // 
            // fotoSecBtn
            // 
            this.fotoSecBtn.Location = new System.Drawing.Point(107, 321);
            this.fotoSecBtn.Name = "fotoSecBtn";
            this.fotoSecBtn.Size = new System.Drawing.Size(75, 24);
            this.fotoSecBtn.TabIndex = 17;
            this.fotoSecBtn.Text = "Seç";
            this.fotoSecBtn.Click += new System.EventHandler(this.fotoSecBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("silBtn.ImageOptions.Image")));
            this.silBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.silBtn.Location = new System.Drawing.Point(260, 370);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(75, 75);
            this.silBtn.TabIndex = 16;
            this.silBtn.Text = "Sil";
            this.silBtn.Click += new System.EventHandler(this.veritabaniBtns_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("guncelleBtn.ImageOptions.Image")));
            this.guncelleBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.guncelleBtn.Location = new System.Drawing.Point(179, 370);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(75, 75);
            this.guncelleBtn.TabIndex = 16;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.Click += new System.EventHandler(this.veritabaniBtns_Click);
            // 
            // temizleBtn
            // 
            this.temizleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("temizleBtn.ImageOptions.Image")));
            this.temizleBtn.Location = new System.Drawing.Point(98, 451);
            this.temizleBtn.Name = "temizleBtn";
            this.temizleBtn.Size = new System.Drawing.Size(237, 46);
            this.temizleBtn.TabIndex = 16;
            this.temizleBtn.Text = "Temizle";
            this.temizleBtn.Click += new System.EventHandler(this.veritabaniBtns_Click);
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("kaydetBtn.ImageOptions.Image")));
            this.kaydetBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.kaydetBtn.Location = new System.Drawing.Point(98, 370);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(75, 75);
            this.kaydetBtn.TabIndex = 16;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.Click += new System.EventHandler(this.veritabaniBtns_Click);
            // 
            // departmanLookUpEdit
            // 
            this.departmanLookUpEdit.Location = new System.Drawing.Point(107, 299);
            this.departmanLookUpEdit.Name = "departmanLookUpEdit";
            this.departmanLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.departmanLookUpEdit.Properties.DisplayMember = "DepartmanAd";
            this.departmanLookUpEdit.Properties.ValueMember = "Id";
            this.departmanLookUpEdit.Size = new System.Drawing.Size(228, 20);
            this.departmanLookUpEdit.TabIndex = 6;
            // 
            // maasTxt
            // 
            this.maasTxt.Location = new System.Drawing.Point(107, 275);
            this.maasTxt.Name = "maasTxt";
            this.maasTxt.Properties.Appearance.Options.UseTextOptions = true;
            this.maasTxt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.maasTxt.Size = new System.Drawing.Size(228, 20);
            this.maasTxt.TabIndex = 5;
            // 
            // telefonTxt
            // 
            this.telefonTxt.Location = new System.Drawing.Point(107, 251);
            this.telefonTxt.Name = "telefonTxt";
            this.telefonTxt.Properties.Appearance.Options.UseTextOptions = true;
            this.telefonTxt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.telefonTxt.Size = new System.Drawing.Size(228, 20);
            this.telefonTxt.TabIndex = 4;
            // 
            // mailTxt
            // 
            this.mailTxt.Location = new System.Drawing.Point(107, 227);
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Properties.Appearance.Options.UseTextOptions = true;
            this.mailTxt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.mailTxt.Size = new System.Drawing.Size(228, 20);
            this.mailTxt.TabIndex = 3;
            // 
            // soyadTxt
            // 
            this.soyadTxt.Location = new System.Drawing.Point(107, 204);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Properties.Appearance.Options.UseTextOptions = true;
            this.soyadTxt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.soyadTxt.Size = new System.Drawing.Size(228, 20);
            this.soyadTxt.TabIndex = 2;
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(107, 180);
            this.adTxt.Name = "adTxt";
            this.adTxt.Properties.Appearance.Options.UseTextOptions = true;
            this.adTxt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.adTxt.Size = new System.Drawing.Size(228, 20);
            this.adTxt.TabIndex = 1;
            // 
            // personelFotoPct
            // 
            this.personelFotoPct.Location = new System.Drawing.Point(140, 23);
            this.personelFotoPct.Name = "personelFotoPct";
            this.personelFotoPct.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.personelFotoPct.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.personelFotoPct.Size = new System.Drawing.Size(158, 151);
            this.personelFotoPct.TabIndex = 15;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(6, 298);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(91, 18);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Departman :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(49, 274);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 18);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "Maaş :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(24, 322);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 18);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Fotoğraf :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(32, 250);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 18);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Telefon :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(56, 226);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 18);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Mail :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(42, 203);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 18);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Soyad :";
            // 
            // departmanlbl
            // 
            this.departmanlbl.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.departmanlbl.Appearance.Options.UseFont = true;
            this.departmanlbl.Location = new System.Drawing.Point(69, 179);
            this.departmanlbl.Name = "departmanlbl";
            this.departmanlbl.Size = new System.Drawing.Size(28, 18);
            this.departmanlbl.TabIndex = 14;
            this.departmanlbl.Text = "Ad :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 511);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "PersonelForm";
            this.Text = "Personel Formu";
            this.Load += new System.EventHandler(this.PersonelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoDosyaYolu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maasTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyadTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelFotoPct.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IdCol;
        private DevExpress.XtraGrid.Columns.GridColumn personelAdCol;
        private DevExpress.XtraGrid.Columns.GridColumn personelSoyadCol;
        private DevExpress.XtraGrid.Columns.GridColumn personelFotoCol;
        private DevExpress.XtraGrid.Columns.GridColumn personelMailCol;
        private DevExpress.XtraGrid.Columns.GridColumn personelTelefonCol;
        private DevExpress.XtraGrid.Columns.GridColumn personelMaasCol;
        private DevExpress.XtraGrid.Columns.GridColumn departmanCol;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PictureEdit personelFotoPct;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl departmanlbl;
        private DevExpress.XtraEditors.SimpleButton silBtn;
        private DevExpress.XtraEditors.SimpleButton guncelleBtn;
        private DevExpress.XtraEditors.SimpleButton temizleBtn;
        private DevExpress.XtraEditors.SimpleButton kaydetBtn;
        private DevExpress.XtraEditors.LookUpEdit departmanLookUpEdit;
        private DevExpress.XtraEditors.TextEdit maasTxt;
        private DevExpress.XtraEditors.TextEdit telefonTxt;
        private DevExpress.XtraEditors.TextEdit mailTxt;
        private DevExpress.XtraEditors.TextEdit soyadTxt;
        private DevExpress.XtraEditors.TextEdit adTxt;
        private DevExpress.XtraEditors.TextEdit fotoDosyaYolu;
        private DevExpress.XtraEditors.SimpleButton fotoSecBtn;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}