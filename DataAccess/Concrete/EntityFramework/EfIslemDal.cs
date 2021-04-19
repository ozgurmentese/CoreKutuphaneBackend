using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfIslemDal : EfEntityRepositoryBase<Islem, KutuphaneContext>, IIslemDal
    {
    }
}
