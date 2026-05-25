//#define FACTORIAL
//#define POWER
//#define FIBONACCI
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SimpleTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if FACTORIAL
            Console.WriteLine("Введите число которое хотите возвести в факториал: ");
            int number = Convert.ToInt32(Console.ReadLine());
            BigInteger Factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                Factorial *= i;
            }
            Console.WriteLine($"Факториал числа {number} равен: {Factorial}"); 
#endif
#if POWER
            Console.WriteLine("Введите число для возведения в степень: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень: ");
            int exponent = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= number;
            }
            Console.WriteLine($"{exponent} степень числа {number} равна {result}"); 
#endif
#if FIBONACCI
            Console.WriteLine("Введите предел для ряда Фибоначчи: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ряд Фибоначчи до {limit}:");
            int a = 0;
            int b = 1;
            Console.Write(a + " ");
            while (b <= limit)
            {
                Console.Write(b + " ");
                int next = a + b;
                a = b;
                b = next;
            }
#endif
        }
    }
}
