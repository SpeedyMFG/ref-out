using System;

namespace ref_out
{
    class Program
    {
        private static int number2;

        static void Main(string[] args)
        {
            //Add();
            //Add();
            //var result = Add2();

            int number1;
            int number2 = 100;
            int number3 = 60;
            int number4 = 200;

            var result2 = Add3(out number1, number2);
            var result3 = Add4(ref number3, number4);

            Console.WriteLine(number1);
            Console.WriteLine(number3);
            Console.WriteLine(result2);
            
            Console.ReadLine();
        }
        static void Add() 
        {
            Console.WriteLine("Added!!!");
        }
        static int Add2(int number1=20,int number2=30)
        {
            var result = number1 + number2;
            return result;
        }
        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Add4(ref int number3, int number4)
        {
            number3 = 50;
            return number3 + number4;
        }

    }
}
