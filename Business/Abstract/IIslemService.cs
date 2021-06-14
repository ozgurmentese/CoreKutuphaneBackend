using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IIslemService
    {
        IDataResult< List<Islem>> GetAll();
        IDataResult<Islem> Get();
        IResult Add(Islem islem);
        IResult Update(Islem islem);
        IResult Delete(Islem islem);
    }
}
