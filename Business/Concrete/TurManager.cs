using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class TurManager : ITurService
    {
        readonly ITurDal _turDal;
        public TurManager(ITurDal turDal)
        {
            _turDal = turDal;
        }

        [ValidationAspect(typeof(TurValidator))]
        public IResult Add(Tur tur)
        {
            _turDal.Add(tur);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Tur tur)
        {
            _turDal.Delete(tur);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<Tur> Get(int id)
        {
            return new SuccessDataResult<Tur>(_turDal.Get(t => t.Id == id), Messages.Listed);
        }

        public IDataResult<List<Tur>> GetAll()
        {
            return new SuccessDataResult<List<Tur>>(_turDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<KitapAdYazarTurGetirDto>> TureGoreGetir2(int v)
        {
            return new SuccessDataResult<List<KitapAdYazarTurGetirDto>>(_turDal.TureGoreGetir2(v), Messages.Listed);
        }

        [ValidationAspect(typeof(TurValidator))]
        public IResult Update(Tur tur)
        {
            _turDal.Update(tur);
            return new SuccessResult(Messages.Updated);
        }
    }
}
