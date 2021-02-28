using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            HesaplaManager hesaplaManager = new HesaplaManager();

            //hesaplaManager.Add();


            //var result = hesaplaManager.Add2(20, 30);
            //Console.WriteLine(result);
            //Console.ReadLine();


            //int number1 = 20;
            //int number2 = 100;
            //var result2 = hesaplaManager.Add3(ref number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);
            //Console.ReadLine();


            //ref yerine out da kullanabiliriz.

            Console.WriteLine(hesaplaManager.Multiplay(2, 4));
            Console.WriteLine(hesaplaManager.Multiplay(2, 4, 5));

            Console.WriteLine(hesaplaManager.Add4(1, 2, 3, 4, 5, 6));
            Console.ReadLine();
            Console.WriteLine();





        }

    }

}
