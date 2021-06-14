using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class KitapManager : IKitapService
    {
        IKitapDal _kitapDal;
        public KitapManager(IKitapDal kitapDal)
        {
            _kitapDal = kitapDal;
        }

        public IResult Add(Kitap kitap)
        {
            _kitapDal.Add(kitap);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Kitap kitap)
        {
            _kitapDal.Delete(kitap);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<Kitap> Get(int id)
        {
            return new SuccessDataResult<Kitap>(_kitapDal.Get(k => k.Id == id), Messages.Listed);
        }

        public IDataResult<List<Kitap>> GetAll()
        {
            return new SuccessDataResult<List<Kitap>>(_kitapDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<KitapAdYazarTurGetirDto>> KitapYazarTurGetir()
        {
            return new SuccessDataResult<List<KitapAdYazarTurGetirDto>>(_kitapDal.KitapYazarTurGetir(), Messages.Listed);
        }

        public IResult Update(Kitap kitap)
        {
            _kitapDal.Update(kitap);
            return new SuccessResult(Messages.Updated);
        }
    }
}
