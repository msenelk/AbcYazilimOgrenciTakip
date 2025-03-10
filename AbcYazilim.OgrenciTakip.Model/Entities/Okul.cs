﻿using AbcYazilim.OgrenciTakip.Model.Attributes;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class Okul : BaseEntityDurum
    {
        [Index("IX_Kod",IsUnique = true)]
        public override string Kod { get ; set ; }

        [Required, StringLength(50), ZorunluAlan("Okul Adı","txtOkulAdi")]
        public string  OkulAdi { get; set; }
        [ZorunluAlan("İl Adı", "txtIl")]
        public long IlId { get; set; }
        [ZorunluAlan("İlçe Adı", "txtIlce")]
        public long IlceId { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public Il Il { get; set; }

        // [ForeingKey("isim")] aşağıda tanımlanan isim haricinden başka bir tanımlama varsa oraya yönlendirmek için yazılır
        public Ilce Ilce { get; set; }
    }
}