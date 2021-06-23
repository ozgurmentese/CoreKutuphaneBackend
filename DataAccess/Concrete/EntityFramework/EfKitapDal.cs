using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfKitapDal : EfEntityRepositoryBase<Kitap, KutuphaneContext>, IKitapDal
    {
        public List<KitapAdYazarTurGetirDto> KitapYazarTurGetir()
        {
            //select O.ograd,O.ogrsoyad,K.kitapadi
            //from Ogrenciler O join Islemler I
            //on O.ogrno = I.ogrno join Kitaplar K
            //on K.kitapno = I.kitapno
            using (KutuphaneContext context = new KutuphaneContext())
            {
                var result = from kitaplar in context.Kitaplar
                             join yazarlar in context.Yazarlar
                             on kitaplar.YazarId equals yazarlar.Id
                             join turler in context.Turler
                             on kitaplar.TurId equals turler.Id
                             select new KitapAdYazarTurGetirDto
                             {
                                 KitapAdi = kitaplar.Ad,
                                 YazarAdi = yazarlar.Ad,
                                 TurAdi = turler.Ad,
                                 TurId = turler.Id,
                                 YazarId = yazarlar.Id
                             };
                return result.ToList();
            }
        }
    }
}
