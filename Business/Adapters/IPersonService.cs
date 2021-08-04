using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Adapters
{
    public interface IPersonService
    {
        Task<bool> VerifyCId(Citizen citizen);
    }
}
