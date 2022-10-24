using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { "Elma", "Karpuz" };

            //instance - örnek
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";
            urun1.StokAdedi = 50;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 60;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.StokAdedi = 90;

            Urun[] urunler = new Urun[] { urun1,urun2 };

            //type syfe - tip güveli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("------------Metotlar--------------");

            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2(urun1);
        }
    }
}


//Do not repeat yourself - DRY - Clean code - Best Practice