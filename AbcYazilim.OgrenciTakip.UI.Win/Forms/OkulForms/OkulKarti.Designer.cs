namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.OkulForms
{
    partial class OkulKarti
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.myKodTextEdit1 = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyKodTextEdit();
            this.txtKod = new DevExpress.XtraLayout.LayoutControlItem();
            this.myTextEdit1 = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyTextEdit();
            this.txtOkulAdi = new DevExpress.XtraLayout.LayoutControlItem();
            this.myButtonEdit1 = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyButtonEdit();
            this.txtIl = new DevExpress.XtraLayout.LayoutControlItem();
            this.myButtonEdit2 = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyButtonEdit();
            this.txtIlce = new DevExpress.XtraLayout.LayoutControlItem();
            this.tglDurum = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyToogleSwitch();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.myMemoEdit1 = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyMemoEdit();
            this.txtAciklama = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myKodTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOkulAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myMemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama)).BeginInit();
            this.SuspendLayout();
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.myMemoEdit1);
            this.myDataLayoutControl.Controls.Add(this.tglDurum);
            this.myDataLayoutControl.Controls.Add(this.myButtonEdit2);
            this.myDataLayoutControl.Controls.Add(this.myButtonEdit1);
            this.myDataLayoutControl.Controls.Add(this.myTextEdit1);
            this.myDataLayoutControl.Controls.Add(this.myKodTextEdit1);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 109);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.layoutControlGroup;
            this.myDataLayoutControl.Size = new System.Drawing.Size(420, 294);
            this.myDataLayoutControl.TabIndex = 2;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.txtKod,
            this.txtOkulAdi,
            this.txtIl,
            this.txtIlce,
            this.layoutControlItem5,
            this.txtAciklama});
            this.layoutControlGroup.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup.Name = "layoutControlGroup";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 200D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 100D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 99D;
            this.layoutControlGroup.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 100D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5});
            this.layoutControlGroup.Size = new System.Drawing.Size(420, 294);
            this.layoutControlGroup.TextVisible = false;
            // 
            // myKodTextEdit1
            // 
            this.myKodTextEdit1.EnterMoveNextControl = true;
            this.myKodTextEdit1.Location = new System.Drawing.Point(65, 12);
            this.myKodTextEdit1.MenuManager = this.ribbonControl;
            this.myKodTextEdit1.Name = "myKodTextEdit1";
            this.myKodTextEdit1.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.myKodTextEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.myKodTextEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.myKodTextEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.myKodTextEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myKodTextEdit1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myKodTextEdit1.Properties.MaxLength = 20;
            this.myKodTextEdit1.Size = new System.Drawing.Size(143, 20);
            this.myKodTextEdit1.StatusBarAciklama = "Kod Giriniz.";
            this.myKodTextEdit1.StyleController = this.myDataLayoutControl;
            this.myKodTextEdit1.TabIndex = 4;
            // 
            // txtKod
            // 
            this.txtKod.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.txtKod.AppearanceItemCaption.Options.UseForeColor = true;
            this.txtKod.Control = this.myKodTextEdit1;
            this.txtKod.Location = new System.Drawing.Point(0, 0);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(200, 24);
            this.txtKod.Text = "Kod";
            this.txtKod.TextSize = new System.Drawing.Size(41, 13);
            // 
            // myTextEdit1
            // 
            this.myTextEdit1.EnterMoveNextControl = true;
            this.myTextEdit1.Location = new System.Drawing.Point(65, 36);
            this.myTextEdit1.MenuManager = this.ribbonControl;
            this.myTextEdit1.Name = "myTextEdit1";
            this.myTextEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myTextEdit1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myTextEdit1.Properties.MaxLength = 50;
            this.myTextEdit1.Size = new System.Drawing.Size(143, 20);
            this.myTextEdit1.StatusBarAciklama = null;
            this.myTextEdit1.StyleController = this.myDataLayoutControl;
            this.myTextEdit1.TabIndex = 5;
            // 
            // txtOkulAdi
            // 
            this.txtOkulAdi.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.txtOkulAdi.AppearanceItemCaption.Options.UseForeColor = true;
            this.txtOkulAdi.Control = this.myTextEdit1;
            this.txtOkulAdi.Location = new System.Drawing.Point(0, 24);
            this.txtOkulAdi.Name = "txtOkulAdi";
            this.txtOkulAdi.OptionsTableLayoutItem.RowIndex = 1;
            this.txtOkulAdi.Size = new System.Drawing.Size(200, 24);
            this.txtOkulAdi.Text = "Okul Adı";
            this.txtOkulAdi.TextSize = new System.Drawing.Size(41, 13);
            // 
            // myButtonEdit1
            // 
            this.myButtonEdit1.EnterMoveNextControl = true;
            this.myButtonEdit1.Id = null;
            this.myButtonEdit1.Location = new System.Drawing.Point(65, 60);
            this.myButtonEdit1.MenuManager = this.ribbonControl;
            this.myButtonEdit1.Name = "myButtonEdit1";
            this.myButtonEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myButtonEdit1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myButtonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.myButtonEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.myButtonEdit1.Size = new System.Drawing.Size(143, 20);
            this.myButtonEdit1.StatusBarAciklama = null;
            this.myButtonEdit1.StatusBarKisaYol = "F4 :";
            this.myButtonEdit1.StatusBarKisaYolAciklama = null;
            this.myButtonEdit1.StyleController = this.myDataLayoutControl;
            this.myButtonEdit1.TabIndex = 6;
            // 
            // txtIl
            // 
            this.txtIl.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.txtIl.AppearanceItemCaption.Options.UseForeColor = true;
            this.txtIl.Control = this.myButtonEdit1;
            this.txtIl.Location = new System.Drawing.Point(0, 48);
            this.txtIl.Name = "txtIl";
            this.txtIl.OptionsTableLayoutItem.RowIndex = 2;
            this.txtIl.Size = new System.Drawing.Size(200, 24);
            this.txtIl.Text = "İl";
            this.txtIl.TextSize = new System.Drawing.Size(41, 13);
            // 
            // myButtonEdit2
            // 
            this.myButtonEdit2.EnterMoveNextControl = true;
            this.myButtonEdit2.Id = null;
            this.myButtonEdit2.Location = new System.Drawing.Point(65, 84);
            this.myButtonEdit2.MenuManager = this.ribbonControl;
            this.myButtonEdit2.Name = "myButtonEdit2";
            this.myButtonEdit2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myButtonEdit2.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myButtonEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.myButtonEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.myButtonEdit2.Size = new System.Drawing.Size(143, 20);
            this.myButtonEdit2.StatusBarAciklama = null;
            this.myButtonEdit2.StatusBarKisaYol = "F4 :";
            this.myButtonEdit2.StatusBarKisaYolAciklama = null;
            this.myButtonEdit2.StyleController = this.myDataLayoutControl;
            this.myButtonEdit2.TabIndex = 7;
            // 
            // txtIlce
            // 
            this.txtIlce.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.txtIlce.AppearanceItemCaption.Options.UseForeColor = true;
            this.txtIlce.Control = this.myButtonEdit2;
            this.txtIlce.Location = new System.Drawing.Point(0, 72);
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.OptionsTableLayoutItem.RowIndex = 3;
            this.txtIlce.Size = new System.Drawing.Size(200, 24);
            this.txtIlce.Text = "İlçe";
            this.txtIlce.TextSize = new System.Drawing.Size(41, 13);
            // 
            // tglDurum
            // 
            this.tglDurum.EnterMoveNextControl = true;
            this.tglDurum.Location = new System.Drawing.Point(313, 12);
            this.tglDurum.MenuManager = this.ribbonControl;
            this.tglDurum.Name = "tglDurum";
            this.tglDurum.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.tglDurum.Properties.Appearance.Options.UseForeColor = true;
            this.tglDurum.Properties.AutoHeight = false;
            this.tglDurum.Properties.AutoWidth = true;
            this.tglDurum.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tglDurum.Properties.OffText = "Pasif";
            this.tglDurum.Properties.OnText = "Aktif";
            this.tglDurum.Size = new System.Drawing.Size(77, 20);
            this.tglDurum.StatusBarAciklama = "Kartın Kullanım Durumunu Seçiniz.";
            this.tglDurum.StyleController = this.myDataLayoutControl;
            this.tglDurum.TabIndex = 8;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.tglDurum;
            this.layoutControlItem5.Location = new System.Drawing.Point(301, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem5.Size = new System.Drawing.Size(99, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // myMemoEdit1
            // 
            this.myMemoEdit1.EnterMoveNextControl = true;
            this.myMemoEdit1.Location = new System.Drawing.Point(65, 108);
            this.myMemoEdit1.MenuManager = this.ribbonControl;
            this.myMemoEdit1.Name = "myMemoEdit1";
            this.myMemoEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myMemoEdit1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myMemoEdit1.Properties.MaxLength = 500;
            this.myMemoEdit1.Size = new System.Drawing.Size(143, 174);
            this.myMemoEdit1.StatusBarAciklama = "Açıklama Giriniz.";
            this.myMemoEdit1.StyleController = this.myDataLayoutControl;
            this.myMemoEdit1.TabIndex = 9;
            // 
            // txtAciklama
            // 
            this.txtAciklama.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.txtAciklama.AppearanceItemCaption.Options.UseForeColor = true;
            this.txtAciklama.Control = this.myMemoEdit1;
            this.txtAciklama.Location = new System.Drawing.Point(0, 96);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.OptionsTableLayoutItem.RowIndex = 4;
            this.txtAciklama.Size = new System.Drawing.Size(200, 178);
            this.txtAciklama.Text = "Açıklama";
            this.txtAciklama.TextSize = new System.Drawing.Size(41, 13);
            // 
            // OkulKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 427);
            this.Controls.Add(this.myDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.Name = "OkulKarti";
            this.Text = "Okul Kartı";
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myKodTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOkulAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myMemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private UserControls.Controls.MyMemoEdit myMemoEdit1;
        private UserControls.Controls.MyToogleSwitch tglDurum;
        private UserControls.Controls.MyButtonEdit myButtonEdit2;
        private UserControls.Controls.MyButtonEdit myButtonEdit1;
        private UserControls.Controls.MyTextEdit myTextEdit1;
        private UserControls.Controls.MyKodTextEdit myKodTextEdit1;
        private DevExpress.XtraLayout.LayoutControlItem txtKod;
        private DevExpress.XtraLayout.LayoutControlItem txtOkulAdi;
        private DevExpress.XtraLayout.LayoutControlItem txtIl;
        private DevExpress.XtraLayout.LayoutControlItem txtIlce;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem txtAciklama;
    }
}