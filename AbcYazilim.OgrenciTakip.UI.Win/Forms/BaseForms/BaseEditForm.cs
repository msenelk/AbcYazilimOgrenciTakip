using DevExpress.XtraBars.Ribbon;
using AbcYazilim.OgrenciTakip.Common.Enums;
using DevExpress.XtraBars;
using System;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.Common.Message;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseEditForm : RibbonForm
    {
        protected internal IslemTuru BaseIslemTuru;
        protected internal long Id;
        protected internal bool RefreshYapilacak;
        protected MyDataLayoutControl DataLayoutControl;
        protected MyDataLayoutControl[] DataLayoutControls;
        protected IBaseBll Bll;
        protected KartTuru BaseKartTuru;
        protected BaseEntity OldEntity;
        protected BaseEntity CurrentEntity;
        protected bool IsLoaded;
        protected bool KayitSonrasiFormuKapat = true;
        public BaseEditForm()
        {
            InitializeComponent();
        }

        protected void EventsLoad()
        {
            // Button Events
            foreach (BarItem button in ribbonControl.Items)
                button.ItemClick += Button_ItemClick;

            // Form Events
            Load += BaseEditForm_Load;

            void ControlEvents(Control control)
            {
                control.KeyDown += Control_KeyDown;
                switch (control)
                {
                    case MyButtonEdit edt:
                        edt.IdChanged += Control_IdChanged;
                        edt.EnabledChange += Control_EnabledChange;
                        edt.ButtonClick += Control_ButtonClick;
                        edt.DoubleClick += Control_DoubleClick;
                        break;
                    case BaseEdit edt:
                        edt.EditValueChanged += Control_EditValueChanged;
                        break;
                }
            }
            if(DataLayoutControls==null)
            {
                if (DataLayoutControl == null) return;
                foreach (Control ctrl in DataLayoutControl.Controls)
                    ControlEvents(ctrl);
            }
            else
                foreach (var layout in DataLayoutControls)
                    foreach (Control ctrl in layout.Controls)
                        ControlEvents(ctrl);
        }

        protected virtual void Control_EnabledChange(object sender, EventArgs e)  {        }

        private void Control_EditValueChanged(object sender, EventArgs e)
        {
            if (!IsLoaded) return;
            GuncelNesneOlustur();
        }

        private void Control_DoubleClick(object sender, EventArgs e)
        {
            SecimYap(sender);
        }

        private void Control_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SecimYap(sender);
        }

        private void Control_IdChanged(object sender, IdChangedEventArgs e)
        {
            if (!IsLoaded) return;
            GuncelNesneOlustur();
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            if(sender is MyButtonEdit edt)
                switch (e.KeyCode)
                {
                    case Keys.Delete when e.Control && e.Shift:
                        edt.Id = null;
                        edt.EditValue = null;
                        break;
                    case Keys.F4:
                    case Keys.Down when e.Modifiers == Keys.Alt:
                        SecimYap(edt);
                        break;
                }
        }

        private void BaseEditForm_Load(object sender, EventArgs e)
        {
            IsLoaded = true;
            GuncelNesneOlustur();
            // SablonYukle();
            // ButonGizleGoster();
            Id=BaseIslemTuru.IdOlustur(OldEntity);

            // Güncelleme Yapılacak
            
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(e.Item == btnYeni)
            {
                // Yetki Kontrolü
                BaseIslemTuru = IslemTuru.EntityInsert;
                Yukle();
            }
            else if(e.Item == btnKaydet)
            {
                Kaydet(false);
            }else if(e.Item == btnGerial)
            {
                GeriAl();
            }else if(e.Item == btnSil)
            {
                // Yetki kontrolü
                EntityDelete();
            }else if(e.Item == btnCikis)
            {
                Close();
            }
        }

        protected virtual void SecimYap(object sender) { }

        private void EntityDelete()
        {
            throw new NotImplementedException();
        }

        private void GeriAl()
        {
            throw new NotImplementedException();
        }

        private bool Kaydet(bool kapanis)
        {
            bool KayitIslemi()
            {
                Cursor.Current = Cursors.WaitCursor;

                switch (BaseIslemTuru)
                {
                    case IslemTuru.EntityInsert:
                        if (EntityInsert())
                            return KayitSonrasiIslemler();
                        break;

                    case IslemTuru.EntitUpdate:
                        if (EntityUpdate())
                            return KayitSonrasiIslemler();
                        break;
                }

                bool KayitSonrasiIslemler()
                {
                    OldEntity = CurrentEntity;
                    RefreshYapilacak = true;
                    ButonEnabledDurumu();

                    if (KayitSonrasiFormuKapat)
                        Close();
                    else
                        BaseIslemTuru = BaseIslemTuru == IslemTuru.EntityInsert ? IslemTuru.EntitUpdate : BaseIslemTuru;
                    
                    return true;
                }
                return false;
            }
            var result = kapanis ? Messages.KapanisMesaj() : Messages.KayitMesaj();
            switch (result)
            {
                case System.Windows.Forms.DialogResult.Yes:
                    return KayitIslemi();
                case System.Windows.Forms.DialogResult.No:
                    if(kapanis)
                        btnKaydet.Enabled = false;
                    return true;
                case System.Windows.Forms.DialogResult.Cancel:
                    return true;
            }
            return false;
        }
        protected virtual bool EntityInsert()
        {
            return ((IBaseGenelBll)Bll).Insert(CurrentEntity);
        }
        protected virtual bool EntityUpdate()
        {
            return ((IBaseGenelBll)Bll).Update(OldEntity, CurrentEntity);
        }

        protected internal virtual void Yukle()
        {

        }

        protected virtual void NesneyiKontrollerBagla(){ }

        protected virtual void GuncelNesneOlustur() { }
        protected internal virtual void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnYeni,btnKaydet,btnGerial,btnSil,OldEntity,CurrentEntity);
        }
    }
}