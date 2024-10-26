using AbcYazilim.OgrenciTakip.Model.Entities.Base;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class Okul : BaseEntityDurum
    {
        public string  OkulAdi { get; set; }
        public long IlId { get; set; }
        public long IlceId { get; set; }
        public string Aciklama { get; set; }

        public Il Il { get; set; }

        // [ForeingKey("isim")] aşağıda tanımlanan isim haricinden başka bir tanımlama varsa oraya yönlendirmek için yazılır
        public Ilce Ilce { get; set; }
    }
}