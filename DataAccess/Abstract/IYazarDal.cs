using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IYazarDal : IEntityRepository<Yazar>
    {
        List<KitapAdYazarTurGetirDto> YazaraGoreGetir2(int yazarId);
    }
}
