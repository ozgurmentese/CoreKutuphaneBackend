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
        public List<OgrenciIslemKitapTablolari> OgrenciAdSoyadKitapGetir()
        {

            //select O.ograd,O.ogrsoyad,K.kitapadi
            //from Ogrenciler O join Islemler I
            //on O.ogrno = I.ogrno join Kitaplar K
            //on K.kitapno = I.kitapno

            using (KutuphaneContext context = new KutuphaneContext())
            {
                var result = from o in context.Ogrenciler
                             join i in context.Islemler
                             on o.Numarasi equals i.Id
                             join k in context.Kitaplar
                             on i.KitapNumarasi equals k.KitapNumarasi
                             select new OgrenciIslemKitapTablolari
                             {
                                 ograd = o.Adi,
                                 ogrsoyad = o.Soyadi,
                                 kitapadi = k.KitapAdi
                             };
                return result.ToList();
            }
        }
    }
}
