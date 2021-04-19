using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class KitapManager : IKitapServis
    {
        IKitapDal _kitapDal;
        public KitapManager(IKitapDal kitapDal)
        {
            _kitapDal = kitapDal;
        }
        public IDataResult<List<Kitap>> GetAll()
        {
            return new SuccessDataResult<List<Kitap>>(_kitapDal.GetAll(),Messages.Listed);
        }

        public IDataResult<List<KitapAdYazarTurGetir>> KitapYazarTurGetir()
        {
            return new SuccessDataResult<List<KitapAdYazarTurGetir>>(_kitapDal.KitapYazarTurGetir(),Messages.Listed);
        }
    }
}
