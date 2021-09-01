using System;
using System.Collections.Generic;
namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            ıhtiyacKrediManager.Hesapla();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();

            Console.WriteLine("**********************");

            IKrediManager ıhtiyacKrediManager2 = new IhtiyacKrediManager();
            ıhtiyacKrediManager2.Hesapla();
            IKrediManager tasitKrediManager2 = new TasitKrediManager();
            tasitKrediManager2.Hesapla();
            IKrediManager konutKrediManager2 = new KonutKrediManager();
            konutKrediManager2.Hesapla();
            Console.WriteLine("*************");
            BasvuruManager basvuruManager = new BasvuruManager();
            DatabaseLoggerService loggerService = new DatabaseLoggerService();
            basvuruManager.BasvuruYap(ıhtiyacKrediManager,loggerService);
            Console.WriteLine("****************");
            List<IKrediManager> krediler = new List<IKrediManager>() { ıhtiyacKrediManager ,tasitKrediManager2};

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
