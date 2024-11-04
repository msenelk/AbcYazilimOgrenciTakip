using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.OkulForms
{
    public partial class OkulKartlari : BaseKartlarForm
    {
        public OkulKartlari()
        {
            InitializeComponent();

            OkulBll bll = new OkulBll();
            // grid.DataSource = bll.List(null);

        }
    }
}
