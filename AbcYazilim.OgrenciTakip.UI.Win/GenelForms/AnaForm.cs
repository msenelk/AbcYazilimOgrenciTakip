using AbcYazilim.OgrenciTakip.UI.Win.Forms.OkulForms;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using DevExpress.XtraBars;
using AbcYazilim.OgrenciTakip.Common.Enums;
using DevExpress.XtraEditors.ColorPick.Picker;

namespace AbcYazilim.OgrenciTakip.UI.Win.GenelForms
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AnaForm()
        {
            InitializeComponent();
            EventsLoad();
        }

        private void EventsLoad()
        {
            foreach (var item in ribbonControl1.Items)
            {
                switch (item)
                {
                    case BarButtonItem btn:
                        btn.ItemClick += Butonlar_ItemClick;
                        break;
                }
            }
        }

        private void Butonlar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item == btnOkulKartlari)
                ShowListForms<OkulListForm>.ShowListForm(KartTuru.Okul);
        }
    }
}
