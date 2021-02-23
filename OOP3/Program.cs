using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediMenager ihtıyacKrediMenager = new IhtıyacKrediMenager();
            IKrediMenager tasitKrediMenager = new TasitKrediMenager();
            IKrediMenager konutKrediMenager = new KonutKrediMenager();

            ILoggerService databaseLoggerService = new datebaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruMenager basvuruMenager = new BasvuruMenager();
            basvuruMenager.BasvuruYap(tasitKrediMenager,databaseLoggerService);


            //NOTT!! :IKrediMenager desek bile ekranda aynı sonucu alırdık.Demek ki ne çıktı,Interfaceler de o interfaceyi implemente eden classın referans numarasını tutabiliyormuş!
            //Interface onu implamente eden classın yerini tutabilir.

            List<IKrediMenager> krediler = new List<IKrediMenager>() {ihtıyacKrediMenager,tasitKrediMenager };

            //basvuruMenager.KrediOnBilgilendirmesiYap(krediler);
            

        }

    }
}
