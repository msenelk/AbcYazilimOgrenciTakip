using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using AbcYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyComboBoxEdit:ComboBoxEdit, IStatusBarKisaYol
    {
       // constructor (yapıcı) kelimesinin kısaltmasıdır. Constructor, bir sınıfın bir örneği oluşturulurken çalışan özel bir metottur.
        public MyComboBoxEdit() // ctor yazarak bunu yapıyoruz unutma !
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor; // Yazı yazılamaması için yaptık.
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAciklama { get; set; }
        public string StatusBarAciklama { get; set;}
    }
}
