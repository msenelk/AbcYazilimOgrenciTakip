using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using System;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.OkulForms
{
    public partial class OkulEditForm : BaseEditForm
    {
        public OkulEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new OkulBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Okul;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new OkulS() : ((OkulBll)Bll).Single(FilterFunctions.Filter<Okul>(Id));
            NesneyiKontrollerBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            txtKod.Text = ((OkulBll)Bll).YeniKodVer();
            txtOkulAdi.Focus();
        }

        protected override void NesneyiKontrollerBagla()
        {
            var entity = (OkulS)OldEntity;
            txtKod.Text=entity.Kod;
            txtOkulAdi.Text=entity.OkulAdi;
            txtIl.Id = entity.IlId;
            txtIl.Text = entity.IlAdi;
            txtIlce.Text = entity.IlceAdi;
            txtAciklama.Text = entity.Aciklama;
            durum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Okul
            {
                Id = Id,
                Kod = KodAdi.Text,
                OkulAdi = txtOkulAdi2.Text,
                IlId = Convert.ToInt64(txtIl.Id),
                IlceId = Convert.ToInt64(txtIlce.Id),
                Aciklama=myTextEdit5.Text,
                Durum=durum.IsOn
            };

            ButonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
            
        }
    }
}