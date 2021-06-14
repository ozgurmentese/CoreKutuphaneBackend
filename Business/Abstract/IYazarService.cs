using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IYazarService
    {
        IDataResult<List<Yazar>> GetAll();
        IDataResult<List<KitapAdYazarTurGetirDto>> YazaraGoreGetir2(int v);
        IResult Add(Yazar yazar);
        IResult Delete(Yazar yazar);
        IResult Update(Yazar yazar);
        IDataResult<Yazar> Get(int id);
    }
}
