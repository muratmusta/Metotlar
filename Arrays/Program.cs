using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Öğretmenin öğrencilerine ait bir listesi var. Bunları çeşitli kod bloklarıyla listeleyeceğiz.
            //1. Yöntem : string değişkende tutuyoruz. Tamamen statik bir yapı..
            string student1 = "Engin";
            string student2 = "Derin";
            string student3 = "Salih";

            Console.WriteLine(student1);
            Console.WriteLine(student2);
            Console.WriteLine(student3);


            Console.WriteLine("-------------- 1. Yöentem Bitti --------------");
            //2.Yöentem : Şimdi de Diziler(Array) vasıtasıyla bir öğrenci listesi hazırlıyoruz.
            //Daha sonra foreach ile listenin her elemanını dönüyoruz. Tek tek her birine student takma ismi ile öğrencileri ekrana yazdırıyoruz.
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("-------------- 2. Yöentem Bitti --------------");

            //3. Yöentem : Dilersek Array' imizi bu şekilde de yazabiliriz.
            string[] students2 = new[] { "Engin", "Salih", "Derin"};

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("-------------- 3. Yöentem Bitti --------------");

            //4. Yöentem : Dilersek de String Array daki new [] kodlarını yazmadan da kullanmamız mümkün.. 
            string[] students3 = { "Engin", "Salih", "Derin" };

            foreach (var student in students3)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("-------------- 4. Yöentem Bitti --------------");
            Console.ReadLine();

        }
    }
}
