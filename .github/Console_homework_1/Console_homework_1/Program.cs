using System;

namespace Console_homework_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число A");
            string A = Console.ReadLine();
            Console.WriteLine("\n Результат:");
            double d = double.Parse(A); //квадрат введённого числа
            d = d * d;
            Console.WriteLine($"{d} - A во 2-ой степени");
            d = d * d;
            Console.WriteLine($"{d} - A в 4-ой степени");
            d = d * d;
            Console.WriteLine($"{d} - A в 8-ой степени");
            Console.ReadLine();
        }
    }
}
