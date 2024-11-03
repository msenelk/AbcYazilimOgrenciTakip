﻿using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.Common.Enums
{
    public enum KartTuru : byte
    {
        [Description("Okul Kartı")]
        Okul = 1, // indexi bir ile başlattık
        [Description("İl Kartı")]
        Il,
        [Description("İlçe Kartı")]
        Ilce
    }
}
