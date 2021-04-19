using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IYazarDal : IEntityRepository<Yazar>
    {
        List<KitapAdYazarTurGetir> YazaraGoreGetir2(int yazarId);
    }
}
