using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IKitapServis
    {
        IDataResult<List<Kitap>> GetAll();
        IDataResult<List<KitapAdYazarTurGetir>> KitapYazarTurGetir();
    }

}
