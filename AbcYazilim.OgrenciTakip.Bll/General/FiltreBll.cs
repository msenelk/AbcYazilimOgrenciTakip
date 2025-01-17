﻿using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Data.Contexts;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class FiltreBll : BaseBll<Filtre, OgrenciTakipContext>, IBaseCommonBll
    {
        public FiltreBll() {}
        public FiltreBll(Control ctrl):base(ctrl) { }

        public BaseEntity Single(Expression<Func<Filtre, bool>> filter)
        {
            return BaseSingle(filter, x => x);
        }

        public IEnumerable<BaseEntity> List(Expression<Func<Filtre, bool>> filter)
        {
            return BaseList(filter, x => x).OrderBy(x => x.Kod).ToList();
        }

        public bool Insert(BaseEntity entity, Expression<Func<Filtre, bool>> filter)
        {
            return BaseInsert(entity, filter);
        }

        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<Filtre, bool>> filter)
        {
            return BaseUpdate(oldEntity, currentEntity, filter);
        }

        public bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, KartTuru.Filtre);
        }

        public string YeniKodVer(Expression<Func<Filtre, bool>> filter)
        {
            return BaseYeniKodVer(KartTuru.Filtre, x => x.Kod, filter);
        }
    }
}