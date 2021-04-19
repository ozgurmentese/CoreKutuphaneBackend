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
    public class OgrenciManager : IOgrenciServis
    {
        IOgrenciDal _ogrenciDal;
        public OgrenciManager(IOgrenciDal ogrenciDal)
        {
            _ogrenciDal = ogrenciDal;
        }

        [ValidationAspect(typeof(OgrenciValidator))]
        public IResult Add(Ogrenci ogrenci)
        {
            //ValidationTools.Validate(new OgrenciValidator(), ogrenci);
            _ogrenciDal.Add(ogrenci);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Ogrenci ogrenci)
        {
            _ogrenciDal.Delete(ogrenci);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Ogrenci>> GetAll() {


            return new SuccessDataResult<List<Ogrenci>>(_ogrenciDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<OgrenciIslemKitapTablolari>> OgrenciAdSoyadKitapGetir()
        {
            return new SuccessDataResult<List<OgrenciIslemKitapTablolari>>(_ogrenciDal.OgrenciAdSoyadKitapGetir(), Messages.Listed);
        }

        public IDataResult<List<Ogrenci>> OgrenciGetir(string text)
        {
            return new SuccessDataResult<List<Ogrenci>>(_ogrenciDal.GetAll(o => o.Adi.ToLower().Contains(text.ToLower())),Messages.Listed);
        }

        [ValidationAspect(typeof(OgrenciValidator))]
        public IResult Update(Ogrenci ogrenci)
        {
            _ogrenciDal.Update(ogrenci);
            return new SuccessResult(Messages.Updated);
        }
    }
}
