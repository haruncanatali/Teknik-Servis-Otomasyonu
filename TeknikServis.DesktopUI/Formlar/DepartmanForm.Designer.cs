
namespace TeknikServis.DesktopUI.Formlar
{
    partial class DepartmanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmanForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.silBtn = new DevExpress.XtraEditors.SimpleButton();
            this.guncelleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.temizleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.kaydetBtn = new DevExpress.XtraEditors.SimpleButton();
            this.departmanAciklamaTxt = new System.Windows.Forms.RichTextBox();
            this.dapartmanAdTxt = new DevExpress.XtraEditors.TextEdit();
            this.departmanlbl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.departmanAdCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.departmanAciklamaCol = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dapartmanAdTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.silBtn);
            this.groupControl1.Controls.Add(this.guncelleBtn);
            this.groupControl1.Controls.Add(this.temizleBtn);
            this.groupControl1.Controls.Add(this.kaydetBtn);
            this.groupControl1.Controls.Add(this.departmanAciklamaTxt);
            this.groupControl1.Controls.Add(this.dapartmanAdTxt);
            this.groupControl1.Controls.Add(this.departmanlbl);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(997, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(353, 511);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Veritabanı İşlemleri";
            // 
            // silBtn
            // 
            this.silBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("silBtn.ImageOptions.Image")));
            this.silBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.silBtn.Location = new System.Drawing.Point(234, 380);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(75, 68);
            this.silBtn.TabIndex = 5;
            this.silBtn.Text = "Sil";
            this.silBtn.Click += new System.EventHandler(this.veritabaniBtns_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("guncelleBtn.ImageOptions.Image")));
            this.guncelleBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.guncelleBtn.Location = new System.Drawing.Point(153, 380);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(75, 68);
            this.guncelleBtn.TabIndex = 4;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.Click += new System.EventHandler(this.veritabaniBtns_Click);
            // 
            // temizleBtn
            // 
            this.temizleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("temizleBtn.ImageOptions.Image")));
            this.temizleBtn.Location = new System.Drawing.Point(72, 451);
            this.temizleBtn.Name = "temizleBtn";
            this.temizleBtn.Size = new System.Drawing.Size(237, 36);
            this.temizleBtn.TabIndex = 6;
            this.temizleBtn.Text = "Temizle";
            this.temizleBtn.Click += new System.EventHandler(this.veritabaniBtns_Click);
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("kaydetBtn.ImageOptions.Image")));
            this.kaydetBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.kaydetBtn.Location = new System.Drawing.Point(72, 380);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(75, 68);
            this.kaydetBtn.TabIndex = 3;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.Click += new System.EventHandler(this.veritabaniBtns_Click);
            // 
            // departmanAciklamaTxt
            // 
            this.departmanAciklamaTxt.Location = new System.Drawing.Point(188, 142);
            this.departmanAciklamaTxt.Name = "departmanAciklamaTxt";
            this.departmanAciklamaTxt.Size = new System.Drawing.Size(153, 201);
            this.departmanAciklamaTxt.TabIndex = 2;
            this.departmanAciklamaTxt.Text = "";
            // 
            // dapartmanAdTxt
            // 
            this.dapartmanAdTxt.Location = new System.Drawing.Point(188, 72);
            this.dapartmanAdTxt.Name = "dapartmanAdTxt";
            this.dapartmanAdTxt.Size = new System.Drawing.Size(153, 20);
            this.dapartmanAdTxt.TabIndex = 1;
            // 
            // departmanlbl
            // 
            this.departmanlbl.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.departmanlbl.Appearance.Options.UseFont = true;
            this.departmanlbl.Location = new System.Drawing.Point(63, 71);
            this.departmanlbl.Name = "departmanlbl";
            this.departmanlbl.Size = new System.Drawing.Size(119, 18);
            this.departmanlbl.TabIndex = 12;
            this.departmanlbl.Text = "Departman Adı :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 141);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(176, 18);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Departman Açıklaması :";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(997, 511);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Yellow;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdCol,
            this.departmanAdCol,
            this.departmanAciklamaCol});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // IdCol
            // 
            this.IdCol.Caption = "gridColumn1";
            this.IdCol.FieldName = "Id";
            this.IdCol.Name = "IdCol";
            // 
            // departmanAdCol
            // 
            this.departmanAdCol.Caption = "Departman Adı";
            this.departmanAdCol.FieldName = "DepartmanAd";
            this.departmanAdCol.Name = "departmanAdCol";
            this.departmanAdCol.Visible = true;
            this.departmanAdCol.VisibleIndex = 0;
            // 
            // departmanAciklamaCol
            // 
            this.departmanAciklamaCol.Caption = "Departman Açıklaması";
            this.departmanAciklamaCol.FieldName = "DepartmanAciklama";
            this.departmanAciklamaCol.Name = "departmanAciklamaCol";
            this.departmanAciklamaCol.Visible = true;
            this.departmanAciklamaCol.VisibleIndex = 1;
            // 
            // DepartmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 511);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "DepartmanForm";
            this.Text = "Departman Formu";
            this.Load += new System.EventHandler(this.DepartmanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dapartmanAdTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton silBtn;
        private DevExpress.XtraEditors.SimpleButton guncelleBtn;
        private DevExpress.XtraEditors.SimpleButton kaydetBtn;
        private System.Windows.Forms.RichTextBox departmanAciklamaTxt;
        private DevExpress.XtraEditors.TextEdit dapartmanAdTxt;
        private DevExpress.XtraEditors.LabelControl departmanlbl;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton temizleBtn;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IdCol;
        private DevExpress.XtraGrid.Columns.GridColumn departmanAdCol;
        private DevExpress.XtraGrid.Columns.GridColumn departmanAciklamaCol;
    }
}