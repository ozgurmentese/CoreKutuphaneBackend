using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IOgrenciServis
    {
        //List<Ogrenci> GetAll();

        IDataResult<List<OgrenciIslemKitapTablolari>> OgrenciAdSoyadKitapGetir();
        IDataResult<List<Ogrenci>> OgrenciGetir(string text);
        IDataResult<List<Ogrenci>> GetAll();
        IResult Add(Ogrenci ogrenci);
        IResult Delete(Ogrenci ogrenci);
        IResult Update(Ogrenci ogrenci);
    }

}
