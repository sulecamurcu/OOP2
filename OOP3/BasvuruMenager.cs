using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruMenager
    {
        //method injection
        public void BasvuruYap(IKrediMenager krediMenager,ILoggerService loggerService)//Bu başvuruyu hangi krediye göre yapmam gerektiğini bana söyle.
        {
            //Basvuran Bilergilerini değerlendirme
            //

           krediMenager.Hesapla(); //Böyle yazarsak tüm başvurular konut kredisi üzerinden hesaplanır.
                                   //Hangi krediyi hesaplamak istiyorsak onun HESAPLASI!

            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediMenager>krediler)
        {
            foreach (var kredi in krediler)//Kredilerdeki(listedeki) her bir kredinin bir operasyonunu yap. 
            {
                kredi.Hesapla();
            }
        }

    }
}
