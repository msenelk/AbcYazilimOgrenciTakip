using AbcYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;

namespace AbcYazilim.OgrenciTakip.Model.Entities.Base
{
    public class BaseEntity :IBaseEntity
    {
        // long olarak üretilen ıd i kendimiz oluşturacağımız için long seçtik
        public long  Id { get; set; }
        public string Kod { get; set; }
    }
}
