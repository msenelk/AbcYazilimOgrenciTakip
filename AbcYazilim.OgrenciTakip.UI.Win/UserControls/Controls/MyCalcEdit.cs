using DevExpress.XtraEditors;
using DevExpress.Utils;
using System.Drawing;
using AbcYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    internal class MyCalcEdit :CalcEdit, IStatusBarKisaYol
    {
        public MyCalcEdit() // kısa yolu ctor tab
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.EditMask = "n2";
            // Rakamları maskelemek için 145.000,01
        }
        public override bool EnterMoveNextControl { get; set; }
        public string StatusBarKisaYol { get; set; } = "F4 : ";
        public string StatusBarKisaYolAciklama { get; set; } = "Hesap Makinesi";
        public string StatusBarAciklama { get ; set ; }
    }
}
