using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Concrete
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1999 && gamer.FirstName == "KADİR" && 
                gamer.LastName == "SEKİ" && gamer.NationalityId == 10547025138)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
