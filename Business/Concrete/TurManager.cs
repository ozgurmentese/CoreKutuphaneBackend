using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class TurManager : ITurServis
    {
        ITurDal _turDal;
        public TurManager(ITurDal turDal)
        {
            _turDal = turDal;
        }
        public IDataResult<List<Tur>> GetAll()
        {
            return new SuccessDataResult<List<Tur>>( _turDal.GetAll(),Messages.Listed);
        }

        public IDataResult<List<KitapAdYazarTurGetir>> TureGoreGetir2(int v)
        {
            return new SuccessDataResult<List<KitapAdYazarTurGetir>>(_turDal.TureGoreGetir2(v),Messages.Listed);
        }
    }



}
