using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Musteri //base class
    {
        /*
        Eğer ki bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsan o nesneye ait değilmiş
        gibi duruyorsa o alan demek ki orada soyutlama hatası yapıyorsun deriz.
        */
        public int Id { get; set; }
        public string MusteriNo { get; set; }
    }
}
