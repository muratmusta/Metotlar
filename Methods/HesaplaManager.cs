using System;
using System.Linq;

namespace Methods
{
    class HesaplaManager
    {
        public void Add()

        {

            Console.WriteLine("Added!!!");
        }

        public int Add2(int number1=20, int number2=30)
        //eğer number değeri verilmezse defult değeri olarak örneğin; 30 u kullan anlamına geliyor.
        //defult değer verirken metodun en sonunda yer alması gerekiyor.
        //gerçek hayatta kdv hesaplama da defult kullanılıyor. Mesala parametre verilmezse %18 ile hesapla, verilirse %8 ile hesapla gibi..
        //önce result diye değişken atıyoruz, ondan sonra return ile döndürüyoruz.
        {
            var result = number1 + number2;
            return result;
        }

        public int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;

        }

        public int Multiplay(int number1, int number2)

        {
            return number1 * number2;

        }

        public int Multiplay(int number1, int number2, int number3)

        {
            return number1 * number2 * number3;

        }

        public int Add4(params int [] numbers)
        {
            return numbers.Sum();
        }

    }
}
