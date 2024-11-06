using AbcYazilim.OgrenciTakip.UI.Win.Forms.OkulForms;
using DevExpress.XtraBars;

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
            if(e.Item == btnOkulKartlari)
            {
                OkulListForm frm = new OkulListForm();
                frm.MdiParent = ActiveForm; // Akif olan formda açıl.
                frm.Show();
            }
        }
    }
}
