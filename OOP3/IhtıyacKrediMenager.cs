using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtıyacKrediMenager : IKrediMenager  //EĞER Kİ BİR SINIF BİR INTERFACE'Yİ BÖYLE KULLANIYORSA BAKIN DİYOR Kİ SEN DİYOR BENİM KREDİ MENAGER KUARALLARIMA UYMAK ZORUNDASIN(kREDİ MENAGER'İN ALTI KIRMIZI İLE ÇİZİLİ,KIZDI).O YÜZDEN HER KREDİ MUTLAKA BU INTERFACEDEKİMETOTLARI İÇERMEK ZORUNDA.BİZE KIZMA SEBEBİ BUDUR.
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Ihtıyaç Kredisi Ödeme Planı Hesaplandı"); ;
        }
    }
}
