﻿namespace AbcYazilim.OgrenciTakip.Model.Entities.Base
{
    public class BaseEntity
    {
        // long olarak üretilen ıd i kendimiz oluşturacağımız için long seçtik
        public long  Id { get; set; }
        public string Kod { get; set; }
    }
}