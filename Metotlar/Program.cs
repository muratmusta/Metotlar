using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi1 = "Elma";
            double fiyati1 = 15;
            string aciklamasi1 = "Amasya Elması";


            string urunAdi2 = "Çilek";
            double fiyati2 = 10;
            string aciklamasi2 = "Büyük çilek";

            string[] meyveler = new string[] { "Elma", "Çilek" };

            Console.WriteLine(urunAdi1, urunAdi2);


            Console.WriteLine("-----------Sayfa Sonu------------");

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);

            }
            Console.WriteLine("-----------Metotlar------------");
            //instance - örnek
            //encapsulation : Kapsülleme, Ayrı ayrı yazacağın ve düzensiz olan bir yapıyı bir düzenin içine sokuyorsun.

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            //ürünü böyle de gönderebiliriz. Neden illa class yapıyoruz?
            //cevap: E-ticaret sitesini düşün; farklı sayfalarda ürünleri listeledin. Sonra yönetim bir de stok adeti ekleyelim dedi.
            //O zaman imzadaki, yani SepetManager daki ***public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)*** bu alanı değiştirmen gerektiği gibi,
            // metodaki parantezin içindeki son elemana stok adedini de değiştirmen gerekiyor.
            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);




            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}


//Dont repeat yourself - DRY - Clean Code - Best Practice 