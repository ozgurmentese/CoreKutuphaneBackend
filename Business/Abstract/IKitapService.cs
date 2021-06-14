using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IKitapService
    {
        IDataResult<List<Kitap>> GetAll();
        IDataResult<List<KitapAdYazarTurGetirDto>> KitapYazarTurGetir();
        IResult Add(Kitap kitap);
        IDataResult<Kitap> Get(int id);
        IResult Delete(Kitap kitap);
        IResult Update(Kitap kitap);
    }
}
