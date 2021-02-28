
namespace TeknikServis.DesktopUI.Formlar
{
    partial class AnasayfaForm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MusteriAdCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.musteriSoyadCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.musteriTelefonCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.musteriStatuCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.webBrowser1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 259);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1350, 252);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Döviz Kurları";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(2, 20);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1346, 230);
            this.webBrowser1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridControl1.Location = new System.Drawing.Point(696, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(654, 259);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MusteriAdCol,
            this.musteriSoyadCol,
            this.musteriTelefonCol,
            this.musteriStatuCol});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // MusteriAdCol
            // 
            this.MusteriAdCol.Caption = "Müşteri Adı";
            this.MusteriAdCol.FieldName = "MusteriAd";
            this.MusteriAdCol.Name = "MusteriAdCol";
            this.MusteriAdCol.Visible = true;
            this.MusteriAdCol.VisibleIndex = 0;
            // 
            // musteriSoyadCol
            // 
            this.musteriSoyadCol.Caption = "Müşteri Soyadı";
            this.musteriSoyadCol.FieldName = "MusteriSoyad";
            this.musteriSoyadCol.Name = "musteriSoyadCol";
            this.musteriSoyadCol.Visible = true;
            this.musteriSoyadCol.VisibleIndex = 1;
            // 
            // musteriTelefonCol
            // 
            this.musteriTelefonCol.Caption = "Müşteri Telefonu";
            this.musteriTelefonCol.FieldName = "MusteriTelefon";
            this.musteriTelefonCol.Name = "musteriTelefonCol";
            this.musteriTelefonCol.Visible = true;
            this.musteriTelefonCol.VisibleIndex = 2;
            // 
            // musteriStatuCol
            // 
            this.musteriStatuCol.Caption = "Müşteri Statüsü";
            this.musteriStatuCol.FieldName = "MusteriStatu";
            this.musteriStatuCol.Name = "musteriStatuCol";
            this.musteriStatuCol.Visible = true;
            this.musteriStatuCol.VisibleIndex = 3;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.webBrowser2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(696, 259);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "groupControl2";
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(2, 2);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(692, 255);
            this.webBrowser2.TabIndex = 0;
            // 
            // AnasayfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 511);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "AnasayfaForm";
            this.Text = "Anasayfa Formu";
            this.Load += new System.EventHandler(this.AnasayfaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MusteriAdCol;
        private DevExpress.XtraGrid.Columns.GridColumn musteriSoyadCol;
        private DevExpress.XtraGrid.Columns.GridColumn musteriTelefonCol;
        private DevExpress.XtraGrid.Columns.GridColumn musteriStatuCol;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.WebBrowser webBrowser2;
    }
}