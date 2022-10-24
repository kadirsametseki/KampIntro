using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            //List<ILoggerService> loggers = new List<ILoggerService>() { new SmsLoggerService(), fileLoggerService };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService>() { new SmsLoggerService(), fileLoggerService });

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, konutKrediManager};
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}