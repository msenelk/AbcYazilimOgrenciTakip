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
            KartTuru = KartTuru.Okul;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = IslemTuru == IslemTuru.EntityInsert ? new OkulS() : ((OkulBll)Bll).Single(FilterFunctions.Filter<Okul>(Id));
        }

        protected override void NesneyiKontrollerBagla()
        {
            var entity = (OkulS)OldEntity;
            txtKod.Text=entity.Kod;
            txtOkulAdi.Text=entity.OkulAdi;
           // txtIl.Id = entity.IlId;
            txtIl.Text = entity.IlAdi;
            txtIlce.Text = entity.IlceAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Okul
            {
                Id = Id,
                Kod = txtKod.Text,
                OkulAdi = txtOkulAdi.Text,
               // IlId = Convert.ToInt64(txtIl.Id),
               // IlceId = Convert.ToInt64(txtIlce.Id),
                Aciklama=txtAciklama.Text,
                Durum=tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }
    }
}