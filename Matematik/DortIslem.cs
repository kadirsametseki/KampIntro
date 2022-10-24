using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class DortIslem
    {
        //Topla(2,3)
        public void Topla(int sayi1, int sayi2)
        {
         
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }

        public void Carp(int sayi1, int sayi2, int sayi3)
        {
            int carp = sayi1 * sayi2 * sayi3;
            Console.WriteLine("Sonuç : " + carp);
        }
    }
}
