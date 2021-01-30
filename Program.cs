using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo continueKey;
            double number, power, result;
            Console.WriteLine("Программа для возведения числа в степень");
            while (true)
            {
                Console.Write("Введите число: ");
                double.TryParse(Console.ReadLine(), out number); ;
                Console.Write("Введите степень: ");
                double.TryParse(Console.ReadLine(), out power); ;
                result = Math.Pow(number, power);
                Console.WriteLine("Результат: " + result);
                Console.WriteLine("Для продолжения нажмите любую кнопку, для остановки программы нажмите N");
                Console.Write("Ожидание действий: ");
                continueKey = Console.ReadKey();
                Console.WriteLine();
                if (continueKey.Key == ConsoleKey.N)
                    Environment.Exit(0);
            }
        }
    }
}
