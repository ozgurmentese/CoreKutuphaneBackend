using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IIslemDal : IEntityRepository<Islem>
    {
        List<KutuphaneKitap> KutuphaneKitaplar(Expression<Func<KutuphaneKitap, bool>> filter = null);
    }
}
