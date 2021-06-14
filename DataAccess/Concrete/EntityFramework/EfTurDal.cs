using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfTurDal : EfEntityRepositoryBase<Tur, KutuphaneContext>, ITurDal
    {
        public List<KitapAdYazarTurGetirDto> TureGoreGetir2(int v)
        {
            using (KutuphaneContext context = new KutuphaneContext())
            {
                var result = from k in context.Kitaplar
                             join y in context.Yazarlar
                             on k.YazarId equals y.Id
                             join t in context.Turler
                             on k.TurId equals t.Id
                             where t.Id == v
                             select new KitapAdYazarTurGetirDto
                             {
                                 KitapAdi = k.Ad,
                                 YazarAdi = y.Ad,
                                 TurAdi = t.Ad,
                                 TurId = t.Id,
                                 YazarId = y.Id
                             };
                return result.ToList();
            }
        }
    }
}
