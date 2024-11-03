﻿using AbcYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using System;
using System.Linq;

namespace AbcYazilim.OgrenciTakip.Bll.Functions
{
    public static class Converts
    {
        public static TTarget EntityConvert<TTarget>(this IBaseEntity source)
        {
            if (source == null) return default(TTarget);
            var hedef = Activator.CreateInstance <TTarget>();
            var kaynakProp = source.GetType().GetProperties();
            var hedefProp = typeof(TTarget).GetProperties(); // buna bu şekilde ulaşıyoruz..

            foreach (var kp in kaynakProp)
            {
                var value = kp.GetValue(source);
                var hp = hedefProp.FirstOrDefault(x=>x.Name == kp.Name); // Kaynak prop ismini al ve hedefprop da ara ve hp ye at
                if(hp != null)
                    hp.SetValue(hedef,ReferenceEquals(value,"") ? null : value);
            }

            return hedef;
        }
    }
}
