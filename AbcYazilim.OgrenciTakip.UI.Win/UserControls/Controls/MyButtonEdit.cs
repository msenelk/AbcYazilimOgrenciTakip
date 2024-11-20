using AbcYazilim.OgrenciTakip.UI.Win.Interfaces;
using DevExpress.XtraEditors; // C# projesinde DevExpress'in sunduğu XtraEditors isimli bileşen kütüphanesini kullanmak için eklenen bir using direktifidir. 
using DevExpress.XtraEditors.Controls; //  DevExpress'in sunduğu XtraEditors.Controls isimli kütüphaneyi kullanmak için eklenen bir using direktifidir. Bu alan, çeşitli kontrol yapılandırma ve stil özelliklerini sağlar. Genellikle editör kontrolleri ve düzenleme davranışları ile ilgili sınıflar ve yapılar içerir.
using System;
using System.ComponentModel;
using System.Drawing; // Bu kütüphane, grafiksel işlemler ve kullanıcı arayüzü elemanlarının görsel özellikleri üzerinde kontrol sağlamak için kullanılır.


namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyButtonEdit:ButtonEdit,IStatusBarKisaYol
    {
        public MyButtonEdit()
        {
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor; //  kullanıcıların bir hücreye veya düzenleme alanına manuel olarak metin girmesini devre dışı bırakmak için kullanılır. 
            // TextEditStyles.Standard: Hem seçim yapılabilir hem de metin düzenlenebilir.
            Properties.AppearanceFocused.BackColor = Color.LightCyan; // kullanıcı tarafından seçildiğinde (odaklandığında), arka plan rengini değiştirmek amacıyla bu özellik kullanılır.

        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; }
        public string StatusBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAciklama { get; set; }

        #region Events
        private long? _id;

        [Browsable(false)] // Property listesinde göstermez.
        public long? Id
        {
            get => _id;
            set
            {
                var oldValue = _id;
                var newValue = value;

                if (newValue == oldValue) return;
                _id = value;
                IdChanged(this, new IdChangedEventArgs(oldValue, newValue));
                EnabledChange(this, EventArgs.Empty);
            }
        }

        public event EventHandler<IdChangedEventArgs> IdChanged = delegate { }; // EventHandler bir olay (event) tanımlamak için kullanılır. Olaylar, bir nesne tarafından başka bir nesneye belirli bir eylemin gerçekleştiğini bildirmek için kullanılır. EventHandler ise, bir olay tetiklendiğinde hangi metodun çalışacağını tanımlayan bir delege'dir 
        public event EventHandler EnabledChange=delegate { };
        #endregion.

    }
    public class IdChangedEventArgs : EventArgs
    {
        public IdChangedEventArgs(long? oldValue, long? newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }
        public long? OldValue{ get;}
        public long? NewValue { get;}
    }
}
