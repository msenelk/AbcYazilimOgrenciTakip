using DevExpress.XtraBars.Ribbon;
using AbcYazilim.OgrenciTakip.Common.Enums;
using DevExpress.XtraBars;
using System;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseEditForm : RibbonForm
    {
        protected internal IslemTuru IslemTuru;
        protected internal long Id;
        protected internal bool RefreshYapilacak;
        protected MyDataLayoutControl DataLayoutControl;
        protected IBaseBll Bll;
        protected KartTuru KartTuru;
        protected BaseEntity OldEntity;
        protected BaseEntity CurrentEntity;
        protected bool IsLoaded;
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
        }

        private void BaseEditForm_Load(object sender, EventArgs e)
        {
            IsLoaded = true;
            GuncelNesneOlustur();
            // SablonYukle();
            // ButonGizleGoster();
            Id=IslemTuru.IdOlustur(OldEntity);

            // Güncelleme Yapılacak
            
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(e.Item == btnYeni)
            {
                // Yetki Kontrolü
                IslemTuru = IslemTuru.EntityInsert;
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

        private void EntityDelete()
        {
            throw new NotImplementedException();
        }

        private void GeriAl()
        {
            throw new NotImplementedException();
        }

        private void Kaydet(bool v)
        {
            throw new NotImplementedException();
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