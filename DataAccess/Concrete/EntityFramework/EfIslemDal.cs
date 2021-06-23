using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfIslemDal : EfEntityRepositoryBase<Islem, KutuphaneContext>, IIslemDal
    {
        public List<KutuphaneKitap> KutuphaneKitaplar(Expression<Func<KutuphaneKitap, bool>> filter = null)
        {
            using (KutuphaneContext context = new KutuphaneContext())
            {
                var result = from kitaplar in context.Kitaplar
                             join islemler in context.Islemler
                             on kitaplar.Id equals islemler.KitapId
                             join ogrenciler in context.Ogrenciler
                             on islemler.OgrenciNumarasi equals ogrenciler.Numarasi
                             select new KutuphaneKitap
                             {
                                 IslemNo = islemler.Id,
                                 AlisTarih = islemler.AlinanTarih,
                                 KitapAdı = kitaplar.Ad,
                                 OgrenciAd = ogrenciler.Adi,
                                 OgrenciSoyad = ogrenciler.Soyadi,
                                 Sinif = ogrenciler.Sinif,
                                 VerisTarih = islemler.VerilenTarih,
                                 ToplamGun = (islemler.VerilenTarih.Value.Day -
                                 islemler.AlinanTarih.Day + (islemler.VerilenTarih.Value.Month -
                                 islemler.AlinanTarih.Month) * 30 +
                                 (islemler.VerilenTarih.Value.Year -
                                 islemler.AlinanTarih.Year) * 365)
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }

        }
    }
}
