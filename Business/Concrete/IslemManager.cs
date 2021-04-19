using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class IslemManager : IIslemServis
    {
        IIslemDal _islemServis;
        public IslemManager(IIslemDal islemServis)
        {
            _islemServis = islemServis;
        }
        public IResult Add(Islem islem)
        {
             _islemServis.Add(islem);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Islem islem)
        {
            _islemServis.Delete(islem);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Islem>> GetAll()
        {
            ;
            return new SuccessDataResult<List<Islem>>(_islemServis.GetAll(), Messages.Listed);
        }

        public IResult Update(Islem islem)
        {
            _islemServis.Update(islem);
            return new SuccessResult(Messages.Updated);
        }
    }



}
