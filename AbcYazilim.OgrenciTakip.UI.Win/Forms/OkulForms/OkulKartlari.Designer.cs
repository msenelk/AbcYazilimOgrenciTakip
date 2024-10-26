namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.OkulForms
{
    partial class OkulKartlari
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
            this.tablo = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridControl();
            this.grid = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridView();
            this.colId = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colKod = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.longNavigator1 = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.colOkulAdi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colIlAdi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colIlceAdi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colAciklama = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // tablo
            // 
            this.tablo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablo.Location = new System.Drawing.Point(0, 109);
            this.tablo.MainView = this.grid;
            this.tablo.MenuManager = this.ribbonControl;
            this.tablo.Name = "tablo";
            this.tablo.Size = new System.Drawing.Size(1019, 502);
            this.tablo.TabIndex = 2;
            this.tablo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grid});
            // 
            // grid
            // 
            this.grid.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grid.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.grid.Appearance.FooterPanel.Options.UseFont = true;
            this.grid.Appearance.FooterPanel.Options.UseForeColor = true;
            this.grid.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.grid.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grid.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grid.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grid.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.grid.Appearance.ViewCaption.Options.UseForeColor = true;
            this.grid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKod,
            this.colOkulAdi,
            this.colIlAdi,
            this.colIlceAdi,
            this.colAciklama});
            this.grid.GridControl = this.tablo;
            this.grid.Name = "grid";
            this.grid.OptionsMenu.EnableColumnMenu = false;
            this.grid.OptionsMenu.EnableFooterMenu = false;
            this.grid.OptionsMenu.EnableGroupPanelMenu = false;
            this.grid.OptionsNavigation.EnterMoveNextColumn = true;
            this.grid.OptionsPrint.AutoWidth = false;
            this.grid.OptionsPrint.PrintFooter = false;
            this.grid.OptionsPrint.PrintGroupFooter = false;
            this.grid.OptionsView.ColumnAutoWidth = false;
            this.grid.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.grid.OptionsView.RowAutoHeight = true;
            this.grid.OptionsView.ShowAutoFilterRow = true;
            this.grid.OptionsView.ShowGroupPanel = false;
            this.grid.OptionsView.ShowViewCaption = true;
            this.grid.StatusBarAciklama = null;
            this.grid.StatusBarKisaYol = null;
            this.grid.StatusBarKisaYolAciklama = null;
            this.grid.ViewCaption = "Okul Kartları";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.StatusBarAciklama = null;
            this.colId.StatusBarKisaYol = null;
            this.colId.StatusBarKisaYolAciklama = null;
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisaYol = null;
            this.colKod.StatusBarKisaYolAciklama = null;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            this.colKod.Width = 130;
            // 
            // longNavigator1
            // 
            this.longNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator1.Location = new System.Drawing.Point(0, 611);
            this.longNavigator1.Name = "longNavigator1";
            this.longNavigator1.Size = new System.Drawing.Size(1019, 24);
            this.longNavigator1.TabIndex = 3;
            // 
            // colOkulAdi
            // 
            this.colOkulAdi.Caption = "Okul Adı";
            this.colOkulAdi.FieldName = "OkulAdi";
            this.colOkulAdi.Name = "colOkulAdi";
            this.colOkulAdi.OptionsColumn.AllowEdit = false;
            this.colOkulAdi.StatusBarAciklama = null;
            this.colOkulAdi.StatusBarKisaYol = null;
            this.colOkulAdi.StatusBarKisaYolAciklama = null;
            this.colOkulAdi.Visible = true;
            this.colOkulAdi.VisibleIndex = 1;
            this.colOkulAdi.Width = 260;
            // 
            // colIlAdi
            // 
            this.colIlAdi.Caption = "İl";
            this.colIlAdi.FieldName = "IlAdi";
            this.colIlAdi.Name = "colIlAdi";
            this.colIlAdi.OptionsColumn.AllowEdit = false;
            this.colIlAdi.StatusBarAciklama = null;
            this.colIlAdi.StatusBarKisaYol = null;
            this.colIlAdi.StatusBarKisaYolAciklama = null;
            this.colIlAdi.Visible = true;
            this.colIlAdi.VisibleIndex = 2;
            this.colIlAdi.Width = 130;
            // 
            // colIlceAdi
            // 
            this.colIlceAdi.Caption = "İlçe";
            this.colIlceAdi.FieldName = "IlceAdi";
            this.colIlceAdi.Name = "colIlceAdi";
            this.colIlceAdi.OptionsColumn.AllowEdit = false;
            this.colIlceAdi.StatusBarAciklama = null;
            this.colIlceAdi.StatusBarKisaYol = null;
            this.colIlceAdi.StatusBarKisaYolAciklama = null;
            this.colIlceAdi.Visible = true;
            this.colIlceAdi.VisibleIndex = 3;
            this.colIlceAdi.Width = 130;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "ColAciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.StatusBarAciklama = null;
            this.colAciklama.StatusBarKisaYol = null;
            this.colAciklama.StatusBarKisaYolAciklama = null;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 4;
            this.colAciklama.Width = 450;
            // 
            // OkulKartlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 659);
            this.Controls.Add(this.tablo);
            this.Controls.Add(this.longNavigator1);
            this.IconOptions.ShowIcon = false;
            this.Name = "OkulKartlari";
            this.Text = "Okul Kartları";
            this.Controls.SetChildIndex(this.longNavigator1, 0);
            this.Controls.SetChildIndex(this.tablo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grid.MyGridControl tablo;
        private UserControls.Grid.MyGridView grid;
        private UserControls.Grid.MyGridColumn colId;
        private UserControls.Grid.MyGridColumn colKod;
        private UserControls.Navigators.LongNavigator longNavigator1;
        private UserControls.Grid.MyGridColumn colOkulAdi;
        private UserControls.Grid.MyGridColumn colIlAdi;
        private UserControls.Grid.MyGridColumn colIlceAdi;
        private UserControls.Grid.MyGridColumn colAciklama;
    }
}