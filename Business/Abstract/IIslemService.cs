using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IIslemService
    {
        IDataResult<List<Islem>> GetAll();
        IDataResult<Islem> Get(int id);
        IResult Add(Islem islem);
        IResult Update(Islem islem);
        IResult Delete(Islem islem);
        IResult TutarBelirle(int id);
        IDataResult<List<KutuphaneKitap>> GetKutuphanedekiKitaplar();
        IDataResult<List<KutuphaneKitap>> GetKutuphanedeOlanKitaplar();
        IDataResult<List<KutuphaneKitap>> GetKutuphanedeOlmayanKitaplar();
    }
}
