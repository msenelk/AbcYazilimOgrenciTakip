﻿using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using AbcYazilim.OgrenciTakip.UI.Win.Interfaces;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyPictureEdit:PictureEdit, IStatusBarKisaYol
    {
        public MyPictureEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.Appearance.ForeColor = Color.Maroon; // Yazı rengi
            Properties.NullText = "Resim Yok";
            Properties.SizeMode = PictureSizeMode.Stretch; // Gelen resmi yayar.
            Properties.ShowMenu = false;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAciklama { get; set; }
        public string StatusBarAciklama { get; set; }
    }
}
