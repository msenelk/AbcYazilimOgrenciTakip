using System;

namespace AbcYazilim.OgrenciTakip.Model.Attributes
{
    public class Kod:Attribute
    {
        public string Descripton { get; }
        public string ControlName { get; }

        /// <summary>
        /// Validation işlemleri sırasında zorunlu olan alanları işaretleme için kullanılacak
        /// </summary>
        /// <param name="description"> Uyarı mesajında gösterilecek olan açıklama </param>
        /// <param name="controlName"> Uyarı mesajı sonrası odaklanacak olan control adı</param>

        public Kod(string description, string controlName)
        {
            Descripton = description;
            ControlName = controlName;
        }
    }
}
