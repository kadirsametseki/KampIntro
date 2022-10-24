using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        //naming convention - isimlendirme kuralı
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urun.Adi);
        }

        public void Ekle2(Urun urun)
        {
            Console.WriteLine("Satın alındı : " + urun.Fiyati + " TL " + urun.StokAdedi + " tane ");
        }
    }
}
