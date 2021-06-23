using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class YazarManager : IYazarService
    {
        readonly IYazarDal _yazarDal;
        public YazarManager(IYazarDal yazarDal)
        {
            _yazarDal = yazarDal;
        }

        [ValidationAspect(typeof(YazarValidator))]
        public IResult Add(Yazar yazar)
        {
            _yazarDal.Add(yazar);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Yazar yazar)
        {
            _yazarDal.Delete(yazar);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<Yazar> Get(int id)
        {
            return new SuccessDataResult<Yazar>(_yazarDal.Get(y => y.Id == id),Messages.Listed);
        }

        public IDataResult<List<Yazar>> GetAll()
        {
            return new SuccessDataResult<List<Yazar>> (_yazarDal.GetAll(),Messages.Listed);
        }

        [ValidationAspect(typeof(YazarValidator))]
        public IResult Update(Yazar yazar)
        {
            _yazarDal.Update(yazar);
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<List<KitapAdYazarTurGetirDto>> YazaraGoreGetir2(int v)
        {
            return new SuccessDataResult<List<KitapAdYazarTurGetirDto>>( _yazarDal.YazaraGoreGetir2(v),Messages.Listed);
        }
    }
}
