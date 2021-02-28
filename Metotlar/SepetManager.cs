using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention - İSİMLENDİRME KURALI
        //syntax
        //Ekle metodu yaptık, program bana ne ekleyeyim diye soruyor. Bizde parametre olarak ona ürün eklemesini söylüyorz.
         public void Ekle(Urun urun)
        {

            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);


        }


        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
           Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);


        }
    }
}
