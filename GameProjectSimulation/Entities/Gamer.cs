using GameProjectSimulation.Abstract;
using GameProjectSimulation.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Entities
{
    internal class Gamer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public long NationalityId { get; set; }
    }
}
