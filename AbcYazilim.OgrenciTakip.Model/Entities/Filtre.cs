﻿using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Attributes;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class Filtre:BaseEntity
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(100),ZorunluAlan("Filtre Adı","txtFiltreAdi")]
        // StringLength Karakter uzunluğu
        public string FiltreAdi { get; set; }

        [Required,StringLength(1000), ZorunluAlan("Filtre Metni", "txtFiltreMetni")]
        public string FiltreMetni { get; set; }

        [Required]
        public KartTuru KartTuru { get; set; }
    }
}
