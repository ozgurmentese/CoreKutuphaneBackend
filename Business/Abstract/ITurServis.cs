using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ITurServis
    {
        IDataResult<List<Tur>> GetAll();
        IDataResult<List<KitapAdYazarTurGetir>> TureGoreGetir2(int v);
    }

}
