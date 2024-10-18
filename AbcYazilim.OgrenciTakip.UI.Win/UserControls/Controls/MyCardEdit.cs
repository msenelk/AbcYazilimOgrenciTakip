using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    public class MyCardEdit : MyTextEdit
    {
        [ToolboxItem(true)]
        public MyCardEdit()
        {
            Properties.Appearance.TextOptions.HAlignment =HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d?"; // Kutucuğun maskesini tanımladık, 4 karakter ve üç çizgiden oluşuyor.
            Properties.Mask.AutoComplete = AutoCompleteType.None; // Otomatik olarak tamamlamamasını söylüyoruz.
            StatusBarAciklama = "Kart No Giriniz.";
           
        }
    }
}
