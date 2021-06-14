using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ITurService
    {
        IDataResult<List<Tur>> GetAll();
        IDataResult<List<KitapAdYazarTurGetirDto>> TureGoreGetir2(int v);
        IResult Add(Tur tur);
        IDataResult<Tur> Get(int id);
        IResult Delete(Tur tur);
        IResult Update(Tur tur);
    }
}
