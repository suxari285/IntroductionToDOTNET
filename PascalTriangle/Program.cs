using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int maxLineLength = n * 4;

            for (int i = 0; i < n; i++)
            {
                StringBuilder line = new StringBuilder();
                long value = 1;
                for (int j = 0; j <= i; j++)
                {
                    line.Append(value).Append("   ");
                    value = value * (i - j) / (j + 1);
                }

                string rowString = line.ToString().TrimEnd();

                int indentSize = (maxLineLength - rowString.Length) / 2;
                string indent = new string(' ', indentSize);

                Console.WriteLine(indent + rowString);
            }
        }

    }
}
