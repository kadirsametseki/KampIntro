using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Adapters
{
    internal class MernisServiceAdapter : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(gamer.NationalityId,gamer.FirstName.ToUpper(),gamer.LastName.ToUpper(),gamer.BirthYear);
        }
    }
}
