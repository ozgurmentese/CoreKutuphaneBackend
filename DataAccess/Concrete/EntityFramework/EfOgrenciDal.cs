using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOgrenciDal : EfEntityRepositoryBase<Ogrenci, KutuphaneContext>, IOgrenciDal
    {
        public List<OgrenciIslemKitapTablolariDto> OgrenciAdSoyadKitapGetir()
        {

            //select O.ograd,O.ogrsoyad,K.kitapadi
            //from Ogrenciler O join Islemler I
            //on O.ogrno = I.ogrno join Kitaplar K
            //on K.kitapno = I.kitapno

            using (KutuphaneContext context = new KutuphaneContext())
            {
                var result = from ogrenciler in context.Ogrenciler
                             join islemler in context.Islemler
                             on ogrenciler.Numarasi equals islemler.Id
                             join kitaplar in context.Kitaplar
                             on islemler.KitapId equals kitaplar.Id
                             select new OgrenciIslemKitapTablolariDto
                             {
                                 Ad = ogrenciler.Adi,
                                 SoyAd = ogrenciler.Soyadi,
                                 KitapAdi = kitaplar.Ad
                             };
                return result.ToList();
            }
        }
    }
}
