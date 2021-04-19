using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class YazarManager : IYazarServis
    {
        IYazarDal _yazarDal;
        public YazarManager(IYazarDal yazarDal)
        {
            _yazarDal = yazarDal;
        }
        public IDataResult<List<Yazar>> GetAll()
        {
            return new SuccessDataResult<List<Yazar>> (_yazarDal.GetAll(),Messages.Listed);
        }

        public IDataResult<List<KitapAdYazarTurGetir>> YazaraGoreGetir2(int v)
        {
            return new SuccessDataResult<List<KitapAdYazarTurGetir>>( _yazarDal.YazaraGoreGetir2(v),Messages.Listed);
        }
    }
}
