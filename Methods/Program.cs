﻿using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //var result = Add2();
            //ref yerine out da kullanabiliriz.

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(ref number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);
            Console.WriteLine(Multiplay(2,4));
            Console.WriteLine(Multiplay(2, 4,5));

            Console.WriteLine(Add4(1,2,3,4,5,6));
            Console.ReadLine(); 
        }


        static void Add()

        {

            Console.WriteLine("Added!!!");
        }

        static int Add2(int number1 = 20, int number2 = 30)
        {
            var result = number1 + number2;
            return result;

        }


        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;

        }

        static int Multiplay(int number1, int number2)

        {
            return number1 * number2;

        }

        static int Multiplay(int number1, int number2, int number3)

        {
            return number1 * number2 * number3;

        }

        static int Add4(params int[] numbers) 
        {
            return numbers.Something();

        }


    }

}
