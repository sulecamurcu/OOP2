using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediMenager  //Burada operasyonlar tanımlayacağız.
                            //Buraya yazacaklarımız bankadaki her kredide olması gereken metotlar olacaktır.Bunu zorunlu yapıyoruz.Yeni bir kredi oluşturulacağı zaman bu Interface'den implementi olduğu için burdaki yazılanlaarı içermek zorunda. 
    {
        void Hesapla();
        void BiseyYap();



        
       // !!!!!!!***Interfaceleri birbirinin alternati olan ama kod içerikleri farklı olan durumlar için kullanırız.
      

    }
}
