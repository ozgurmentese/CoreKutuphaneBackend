using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfYazarDal : EfEntityRepositoryBase<Yazar, KutuphaneContext>, IYazarDal
    {
        public List<KitapAdYazarTurGetir> YazaraGoreGetir2(int yazarId)
        {
            using (KutuphaneContext context = new KutuphaneContext())
            {
                var result = from k in context.Kitaplar
                             join y in context.Yazarlar
                             on k.YazarNumarasi equals y.YazarNumarasi
                             join t in context.Turler
                             on k.TurNumarasi equals t.Id
                             where y.YazarNumarasi == yazarId
                             select new KitapAdYazarTurGetir
                             {
                                 kitapadi = k.KitapAdi,
                                 yazaradi = y.YazarAd,
                                 turadi = t.TurAdi,
                                 turno = t.Id,
                                 yazarno = y.YazarNumarasi
                             };
                return result.ToList();
            }
        }
    }
}
