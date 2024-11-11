using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.OkulForms
{
    public partial class OkulListForm : BaseListForm
    {
        public OkulListForm()
        {
            InitializeComponent();
            // Bll = new OkulBll();
            OkulBll bll = new OkulBll();
            grid.DataSource = bll.List(null);
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            KartTuru = KartTuru.Okul;
            FormShow = new ShowEditForms<OkulEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource=((OkulBll)Bll).List(FilterFunctions.Filter<Okul>(AktifKartlariGoster));
        }

    }
}
