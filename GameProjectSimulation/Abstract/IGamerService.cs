using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Abstract
{
    internal interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
