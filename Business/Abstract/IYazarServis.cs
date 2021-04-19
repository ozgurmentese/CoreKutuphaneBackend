using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IYazarServis
    {
        IDataResult<List<Yazar>> GetAll();
        IDataResult<List<KitapAdYazarTurGetir>> YazaraGoreGetir2(int v);
    }

}
