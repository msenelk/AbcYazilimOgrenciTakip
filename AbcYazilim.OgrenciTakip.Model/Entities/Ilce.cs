using AbcYazilim.OgrenciTakip.Model.Entities.Base;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class Ilce : BaseEntityDurum
    {
        public string IlceAdi { get; set; }
        // İlçe ile İl i bağlamak için il ıd çekiyoruz
        public long IlId { get; set; }
        public string Aciklama { get; set; }

        // Il sonuna Id ekleyerek yukarıda arama yapacak...
        public Il Il { get; set; }
    }
}