using AbcYazilim.OgrenciTakip.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AbcYazilim.Dal.Interfaces
{
    public interface IRepository<T>:IDisposable where T : class // sadece class tipini kabul et
    {
        void Insert(T entity); // Tanımlama yapılmıyor sadece gövde üst kısmı tanımlanır.
        void Insert(IEnumerable<T> entities); // Birden çok entiti gönderiminde kayıt işlemini yapmak için..
        void Update(T entity);
        void Update(T entity,IEnumerable<string> fields);
        // entitinin değişen alanlarını yüklemek için 
        void Update(IEnumerable<T> entities);
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);
        TResult Find<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T,TResult>> selector);
        // Burada sorgulama sırasında varsa eğer o değeri döndürecek
        // Geriye döndürülecek tipi bilmediğimiz için TResult yaptık
        IQueryable<TResult> Select<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector);
        // T türünü içeren filtre göndereceğiz bu filtre ile sorgulama yap sorgu sonucu true ise bunları bana geriye gönder. Sorgu gönderir değer değil. Listeleme ayrı olacak
        string YeniKodVer(KartTuru kartTuru, Expression<Func<T, string>> filter, Expression<Func<T, bool>> where = null);
    }
}
