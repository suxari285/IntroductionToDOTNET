using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер фигуры (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write("  ");
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write("  ");
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                    Console.Write(" ");
                Console.Write("/");
                for (int j = 0; j < 2 * i; j++)
                    Console.Write(" ");
                Console.WriteLine("\\");
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write(" ");
                Console.Write("\\");
                for (int j = 0; j < 2 * (n - i - 1); j++)
                    Console.Write(" ");
                Console.WriteLine("/");
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i + j) % 2 == 0)
                        Console.Write("+ ");
                    else
                        Console.Write("- ");
                }
                Console.WriteLine();
            }
        }
    }
}
