using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class IslemManager : IIslemService
    {
        readonly IIslemDal _islemDal;
        public IslemManager(IIslemDal islemDal)
        {
            _islemDal = islemDal;
        }

        [ValidationAspect(typeof(IslemValidator))]
        public IResult Add(Islem islem)
        {
            islem.AlinanTarih = DateTime.Now;
            _islemDal.Add(islem);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Islem islem)
        {
            _islemDal.Delete(islem);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<Islem> Get(int id)
        {
            return new SuccessDataResult<Islem>(_islemDal.Get(i => i.Id == id));
        }

        public IDataResult<List<Islem>> GetAll()
        {

            return new SuccessDataResult<List<Islem>>(_islemDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<KutuphaneKitap>> KutuphanedeOlmayanKitaplar()
        {
            var result = _islemDal.KutuphaneKitaplar(k => k.VerisTarih == null);
            return new SuccessDataResult<List<KutuphaneKitap>>(result);
        }

        public IDataResult<List<KutuphaneKitap>> KutuphanedeOlanKitaplar()
        {
            var result = _islemDal.KutuphaneKitaplar(k => k.VerisTarih != null);
            return new SuccessDataResult<List<KutuphaneKitap>>(result);
        }

        public IDataResult<List<KutuphaneKitap>> KutuphanedekiKitaplar()
        {
            var result = _islemDal.KutuphaneKitaplar();
            return new SuccessDataResult<List<KutuphaneKitap>>(result, Messages.Listed);
        }

        [ValidationAspect(typeof(IslemValidator))]
        public IResult Update(Islem islem)
        {
            _islemDal.Update(islem);
            return new SuccessResult(Messages.Updated);
        }

        public IResult TutarBelirle(int id)
        {
            var result = _islemDal.Get(i => i.Id == id);
            var VerilenTarih = DateTime.Now;
            var AlinanTarih = result.AlinanTarih;
            var tarih = (VerilenTarih.Day - AlinanTarih.Day) +
                        (VerilenTarih.Month - AlinanTarih.Month) * 30 +
                        (VerilenTarih.Year - AlinanTarih.Year) * 365;
            if (tarih <= 30)
            {
                return new SuccessResult("Kitap zamanında teslim edilmiştir");
            }
            tarih -= 30;
            double sonuc = 5 + (double)tarih / 7;
            
            return new ErrorResult("Ödenecek ücret = " + Math.Ceiling(sonuc));
        }
    }
}
