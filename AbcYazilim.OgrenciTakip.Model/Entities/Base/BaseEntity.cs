using AbcYazilim.OgrenciTakip.Model.Attributes;
using AbcYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Entities.Base
{
    public class BaseEntity :IBaseEntity
    {
        [Column(Order = 0), Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        // long olarak üretilen ıd i kendimiz oluşturacağımız için long seçtik
        public long  Id { get; set; }
        [Column(Order = 1),Required, StringLength(20),Kod("Kod","txtKod"),ZorunluAlan("Kod","txtKod")]
        public virtual string Kod { get; set; }
    }
}
