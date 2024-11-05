﻿using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class Ilce : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set ; }
        [Required, StringLength(50)]
        public string IlceAdi { get; set; }
        // İlçe ile İl i bağlamak için il ıd çekiyoruz
        public long IlId { get; set; }
        [StringLength(500)]
        public string Aciklama { get; set; }

        // Il sonuna Id ekleyerek yukarıda arama yapacak...
        public Il Il { get; set; }
    }
}