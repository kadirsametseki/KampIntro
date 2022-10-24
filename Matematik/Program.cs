using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortislem = new DortIslem();
            dortislem.Topla(5, 6);
            dortislem.Topla(7, 3);

            dortislem.Carp(3, 5, 7);
        }
    }
}