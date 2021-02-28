
namespace TeknikServis.DesktopUI.Formlar
{
    partial class ArizaListesiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArizaListesiForm));
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UrunCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.personelCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.musteriCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gelisTarihiCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cikisTarihiCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.seriNoCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.arizaliUrunKasaLbl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.enFazlaArizaliMarkaLbl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.parcaBekleyenUrunSayisiLbl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.toplamUrunSayisiLbl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tamirEdilmisUrunSayisiLbl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.arizaliUrunSayisiLbl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(610, 511);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdCol,
            this.UrunCol,
            this.personelCol,
            this.musteriCol,
            this.gelisTarihiCol,
            this.cikisTarihiCol,
            this.seriNoCol});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // IdCol
            // 
            this.IdCol.Caption = "Id";
            this.IdCol.FieldName = "Id";
            this.IdCol.Name = "IdCol";
            // 
            // UrunCol
            // 
            this.UrunCol.Caption = "Ürün";
            this.UrunCol.FieldName = "Urun";
            this.UrunCol.Name = "UrunCol";
            this.UrunCol.Visible = true;
            this.UrunCol.VisibleIndex = 0;
            // 
            // personelCol
            // 
            this.personelCol.Caption = "Personel";
            this.personelCol.FieldName = "Personel";
            this.personelCol.Name = "personelCol";
            this.personelCol.Visible = true;
            this.personelCol.VisibleIndex = 1;
            // 
            // musteriCol
            // 
            this.musteriCol.Caption = "Müşteri";
            this.musteriCol.FieldName = "Musteri";
            this.musteriCol.Name = "musteriCol";
            this.musteriCol.Visible = true;
            this.musteriCol.VisibleIndex = 2;
            // 
            // gelisTarihiCol
            // 
            this.gelisTarihiCol.Caption = "Geliş Tarihi";
            this.gelisTarihiCol.FieldName = "GelisTarihi";
            this.gelisTarihiCol.Name = "gelisTarihiCol";
            this.gelisTarihiCol.Visible = true;
            this.gelisTarihiCol.VisibleIndex = 3;
            // 
            // cikisTarihiCol
            // 
            this.cikisTarihiCol.Caption = "Çıkış Tarihi";
            this.cikisTarihiCol.FieldName = "CikisTarihi";
            this.cikisTarihiCol.Name = "cikisTarihiCol";
            this.cikisTarihiCol.Visible = true;
            this.cikisTarihiCol.VisibleIndex = 4;
            // 
            // seriNoCol
            // 
            this.seriNoCol.Caption = "Seri Numarası";
            this.seriNoCol.FieldName = "SeriNo";
            this.seriNoCol.Name = "seriNoCol";
            this.seriNoCol.Visible = true;
            this.seriNoCol.VisibleIndex = 5;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupBox6);
            this.groupControl1.Controls.Add(this.groupBox5);
            this.groupControl1.Controls.Add(this.groupBox3);
            this.groupControl1.Controls.Add(this.groupBox4);
            this.groupControl1.Controls.Add(this.groupBox2);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Controls.Add(this.chartControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(616, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(734, 511);
            this.groupControl1.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox6.Controls.Add(this.pictureBox4);
            this.groupBox6.Controls.Add(this.arizaliUrunKasaLbl);
            this.groupBox6.Controls.Add(this.labelControl2);
            this.groupBox6.Location = new System.Drawing.Point(5, 118);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(235, 100);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(175, 44);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // arizaliUrunKasaLbl
            // 
            this.arizaliUrunKasaLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arizaliUrunKasaLbl.Appearance.ForeColor = System.Drawing.Color.White;
            this.arizaliUrunKasaLbl.Appearance.Options.UseFont = true;
            this.arizaliUrunKasaLbl.Appearance.Options.UseForeColor = true;
            this.arizaliUrunKasaLbl.Location = new System.Drawing.Point(6, 61);
            this.arizaliUrunKasaLbl.Name = "arizaliUrunKasaLbl";
            this.arizaliUrunKasaLbl.Size = new System.Drawing.Size(51, 23);
            this.arizaliUrunKasaLbl.TabIndex = 0;
            this.arizaliUrunKasaLbl.Text = "NULL";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(129, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Arızalı Ürün Kasa";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(203)))), ((int)(((byte)(56)))));
            this.groupBox5.Controls.Add(this.pictureBox6);
            this.groupBox5.Controls.Add(this.enFazlaArizaliMarkaLbl);
            this.groupBox5.Controls.Add(this.labelControl6);
            this.groupBox5.Location = new System.Drawing.Point(500, 118);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(222, 100);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(162, 44);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(54, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            // 
            // enFazlaArizaliMarkaLbl
            // 
            this.enFazlaArizaliMarkaLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.enFazlaArizaliMarkaLbl.Appearance.ForeColor = System.Drawing.Color.White;
            this.enFazlaArizaliMarkaLbl.Appearance.Options.UseFont = true;
            this.enFazlaArizaliMarkaLbl.Appearance.Options.UseForeColor = true;
            this.enFazlaArizaliMarkaLbl.Location = new System.Drawing.Point(6, 61);
            this.enFazlaArizaliMarkaLbl.Name = "enFazlaArizaliMarkaLbl";
            this.enFazlaArizaliMarkaLbl.Size = new System.Drawing.Size(51, 23);
            this.enFazlaArizaliMarkaLbl.TabIndex = 0;
            this.enFazlaArizaliMarkaLbl.Text = "NULL";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(6, 20);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(166, 18);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "En Fazla Arızalı Marka";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.parcaBekleyenUrunSayisiLbl);
            this.groupBox3.Controls.Add(this.labelControl4);
            this.groupBox3.Location = new System.Drawing.Point(500, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(162, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // parcaBekleyenUrunSayisiLbl
            // 
            this.parcaBekleyenUrunSayisiLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parcaBekleyenUrunSayisiLbl.Appearance.ForeColor = System.Drawing.Color.White;
            this.parcaBekleyenUrunSayisiLbl.Appearance.Options.UseFont = true;
            this.parcaBekleyenUrunSayisiLbl.Appearance.Options.UseForeColor = true;
            this.parcaBekleyenUrunSayisiLbl.Location = new System.Drawing.Point(6, 59);
            this.parcaBekleyenUrunSayisiLbl.Name = "parcaBekleyenUrunSayisiLbl";
            this.parcaBekleyenUrunSayisiLbl.Size = new System.Drawing.Size(51, 23);
            this.parcaBekleyenUrunSayisiLbl.TabIndex = 0;
            this.parcaBekleyenUrunSayisiLbl.Text = "NULL";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(6, 20);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(206, 18);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Parça Bekleyen Ürün Sayısı";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(117)))));
            this.groupBox4.Controls.Add(this.pictureBox5);
            this.groupBox4.Controls.Add(this.toplamUrunSayisiLbl);
            this.groupBox4.Controls.Add(this.labelControl5);
            this.groupBox4.Location = new System.Drawing.Point(246, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 100);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(188, 44);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(54, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // toplamUrunSayisiLbl
            // 
            this.toplamUrunSayisiLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamUrunSayisiLbl.Appearance.ForeColor = System.Drawing.Color.White;
            this.toplamUrunSayisiLbl.Appearance.Options.UseFont = true;
            this.toplamUrunSayisiLbl.Appearance.Options.UseForeColor = true;
            this.toplamUrunSayisiLbl.Location = new System.Drawing.Point(6, 61);
            this.toplamUrunSayisiLbl.Name = "toplamUrunSayisiLbl";
            this.toplamUrunSayisiLbl.Size = new System.Drawing.Size(51, 23);
            this.toplamUrunSayisiLbl.TabIndex = 0;
            this.toplamUrunSayisiLbl.Text = "NULL";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(6, 20);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(144, 18);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Toplam Ürün Sayısı";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.tamirEdilmisUrunSayisiLbl);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Location = new System.Drawing.Point(246, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(188, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // tamirEdilmisUrunSayisiLbl
            // 
            this.tamirEdilmisUrunSayisiLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tamirEdilmisUrunSayisiLbl.Appearance.ForeColor = System.Drawing.Color.White;
            this.tamirEdilmisUrunSayisiLbl.Appearance.Options.UseFont = true;
            this.tamirEdilmisUrunSayisiLbl.Appearance.Options.UseForeColor = true;
            this.tamirEdilmisUrunSayisiLbl.Location = new System.Drawing.Point(6, 59);
            this.tamirEdilmisUrunSayisiLbl.Name = "tamirEdilmisUrunSayisiLbl";
            this.tamirEdilmisUrunSayisiLbl.Size = new System.Drawing.Size(51, 23);
            this.tamirEdilmisUrunSayisiLbl.TabIndex = 0;
            this.tamirEdilmisUrunSayisiLbl.Text = "NULL";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(6, 20);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(191, 18);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Tamir Edilmiş Ürün Sayısı";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.arizaliUrunSayisiLbl);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(175, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // arizaliUrunSayisiLbl
            // 
            this.arizaliUrunSayisiLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arizaliUrunSayisiLbl.Appearance.ForeColor = System.Drawing.Color.White;
            this.arizaliUrunSayisiLbl.Appearance.Options.UseFont = true;
            this.arizaliUrunSayisiLbl.Appearance.Options.UseForeColor = true;
            this.arizaliUrunSayisiLbl.Location = new System.Drawing.Point(6, 59);
            this.arizaliUrunSayisiLbl.Name = "arizaliUrunSayisiLbl";
            this.arizaliUrunSayisiLbl.Size = new System.Drawing.Size(51, 23);
            this.arizaliUrunSayisiLbl.TabIndex = 0;
            this.arizaliUrunSayisiLbl.Text = "NULL";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(139, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Arızalı Ürün Sayısı";
            // 
            // chartControl1
            // 
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(6, 224);
            this.chartControl1.Name = "chartControl1";
            series1.LegendTextPattern = "{A}";
            series1.Name = "Series 1";
            series1.View = pieSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(716, 287);
            this.chartControl1.TabIndex = 1;
            // 
            // ArizaListesiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 511);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "ArizaListesiForm";
            this.Text = "Arıza Listesi";
            this.Load += new System.EventHandler(this.ArizaListesiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private DevExpress.XtraEditors.LabelControl arizaliUrunKasaLbl;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.LabelControl enFazlaArizaliMarkaLbl;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private DevExpress.XtraEditors.LabelControl parcaBekleyenUrunSayisiLbl;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private DevExpress.XtraEditors.LabelControl toplamUrunSayisiLbl;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.LabelControl tamirEdilmisUrunSayisiLbl;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl arizaliUrunSayisiLbl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn IdCol;
        private DevExpress.XtraGrid.Columns.GridColumn UrunCol;
        private DevExpress.XtraGrid.Columns.GridColumn personelCol;
        private DevExpress.XtraGrid.Columns.GridColumn musteriCol;
        private DevExpress.XtraGrid.Columns.GridColumn gelisTarihiCol;
        private DevExpress.XtraGrid.Columns.GridColumn cikisTarihiCol;
        private DevExpress.XtraGrid.Columns.GridColumn seriNoCol;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}