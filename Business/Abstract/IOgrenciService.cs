using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IOgrenciService
    {
        //List<Ogrenci> GetAll();

        IDataResult<List<OgrenciIslemKitapTablolariDto>> OgrenciAdSoyadKitapGetir();
        IDataResult<List<Ogrenci>> OgrenciGetir(string text);
        IDataResult<List<Ogrenci>> GetAll();
        IResult Add(Ogrenci ogrenci);
        IResult Delete(Ogrenci ogrenci);
        IResult Update(Ogrenci ogrenci);
    }

}
