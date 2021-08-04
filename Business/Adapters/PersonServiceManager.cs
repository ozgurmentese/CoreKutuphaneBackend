using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using KpsServiceReference;
using System.Threading.Tasks;

namespace Business.Adapters
{
    public class PersonServiceManager : IPersonService
    {
        public async Task<bool> VerifyCId(Citizen citizen)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(citizen.CitizenId), 
                citizen.Name.ToUpper(), citizen.SurName.ToUpper(), citizen.BirhYear);
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
