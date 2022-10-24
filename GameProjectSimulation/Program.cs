using GameProjectSimulation.Concrete;
using GameProjectSimulation.Entities;
using GameProjectSimulation.Adapters;
using System;

namespace isim
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer() { Id = 1, BirthYear = 1999, FirstName = "KADİR", LastName = "SEKİ", NationalityId = 10547025138 });
        }
    }
}