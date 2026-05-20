using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static string delimetr = "\n--------------------------------------------------\n";
        static void Main(string[] args)
        {
            Console.WriteLine("Data types");
            Console.WriteLine(delimetr);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Bool");
            Console.WriteLine(true);
            Console.WriteLine(false);
            Console.WriteLine(sizeof(bool));
            Console.WriteLine(true.GetType());
            Console.ResetColor();
            Console.WriteLine(delimetr);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Char");
            Console.WriteLine(sizeof(char));
            Console.ResetColor();
            Console.WriteLine(delimetr);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Byte");
            Console.WriteLine("Size: "+sizeof(byte)+" byte");
            Console.WriteLine($"Range:{byte.MinValue} ... {byte.MaxValue}");
            Console.WriteLine(((byte)0).GetType());
            Console.ResetColor();
            Console.WriteLine(delimetr);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sbyte");
            Console.WriteLine($"Size: {sizeof(sbyte)} byte");
            Console.WriteLine($"Range:{sbyte.MinValue} ... {sbyte.MaxValue}");
            Console.WriteLine(((sbyte)0).GetType());
            Console.ResetColor();
            Console.WriteLine(delimetr);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Short");
            Console.WriteLine($"Size: {sizeof(short)}");
            Console.WriteLine($"Range:{short.MinValue} ... {short.MaxValue}");
            Console.WriteLine(((short)0).GetType());
            Console.ResetColor();
            Console.WriteLine(delimetr);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Ushort");
            Console.WriteLine($"Size: {sizeof(ushort)}");
            Console.WriteLine($"Range:{ushort.MinValue} ... {ushort.MaxValue}");
            Console.WriteLine(((ushort)0).GetType());
            Console.ResetColor();
            Console.WriteLine(delimetr);
        }
    }
}
