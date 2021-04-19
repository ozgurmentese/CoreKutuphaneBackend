using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IIslemServis
    {
        IDataResult< List<Islem>> GetAll();
        IResult Add(Islem islem);
        IResult Update(Islem islem);
        IResult Delete(Islem islem);
    }

}
