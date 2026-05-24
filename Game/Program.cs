using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            Console.SetCursorPosition(x, y);
            Console.Write('*');
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    int oldX = x; 
                    int oldY = y;

                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.W) y--;
                    if (key == ConsoleKey.S) y++;
                    if (key == ConsoleKey.A) x--;
                    if (key == ConsoleKey.D) x++;
                    if (key == ConsoleKey.Spacebar) Console.Beep(200, 300);

                    Console.SetCursorPosition(oldX, oldY);
                    Console.Write(' ');

                    Console.SetCursorPosition(x, y);
                    Console.Write('*');

                }
            }
        }
    }
}
