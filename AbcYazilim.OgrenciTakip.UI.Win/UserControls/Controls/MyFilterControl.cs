using AbcYazilim.OgrenciTakip.UI.Win.Interfaces;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyFilterControl:FilterControl, IStatusBarAciklama
    {
        public MyFilterControl()
        {
            ShowGroupCommandsIcon = true; // Filtreleme grup yapımı için..
        }

        public string StatusBarAciklama { get; set; } = "Filtre Metni Giriniz.";
    }
}
