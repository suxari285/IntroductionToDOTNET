//#define FIRST_ATTEMPT
//#define CHAR_CONTROL
//#define SHOOTER

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
#if FIRST_ATTEMPT
            int x = 0;
            int y = 0;
            Console.SetCursorPosition(x, y);
            Console.Write('*');
            while (true)
            {
                int oldX = x;
                int oldY = y;

                string key = Convert.ToString(Console.ReadLine());
                if (key == "W" || key == "w") y--;
                if (key == "S" || key == "s") y++;
                if (key == "A" || key == "A") x--;
                if (key == "D" || key == "d") x++;
                if (key == " ") Console.Beep(200, 300);

                Console.SetCursorPosition(oldX, oldY);
                Console.Write(' ');

                Console.SetCursorPosition(x, y);
                Console.Write('*');
            }  
#endif

#if CHAR_CONTROL
            char key;
            do
            {
                key = Console.ReadKey(true).KeyChar;
                //Console.WriteLine($"{(int)key}\t{key}");
                switch (key)
                {
                    case 'ц': Console.WriteLine("Вверх"); break;
                    case 'w': Console.WriteLine("Вверх"); break;
                    case 'ы': Console.WriteLine("Вниз"); break;
                    case 's': Console.WriteLine("Вниз"); break;
                    case 'ф': Console.WriteLine("Влево"); break;
                    case 'a': Console.WriteLine("Влево"); break;
                    case 'в': Console.WriteLine("Вправо"); break;
                    case 'd': Console.WriteLine("Вправо"); break;
                }
            } while (key != 27); 
#endif
#if SHOOTER
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                //Console.WriteLine($"{key}");
                switch (key)
                {
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("Up"); break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("Down"); break;
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("Left"); break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("Right"); break;
                    case ConsoleKey.Spacebar: Console.WriteLine("Jump"); break;
                    case ConsoleKey.Enter: Console.WriteLine("FIRE!"); Console.Beep(200, 100); break;
                }
            } while (key != ConsoleKey.Escape); 
#endif
            ConsoleKey key;
            int x = 10;
            int y = 10;
            const char symbol = '@';
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.WriteLine(symbol);
                key = Console.ReadKey(true).Key;
                switch(key)
                {
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:y--;break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:y++;break;
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow: x--;break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:x++;break;
                    case ConsoleKey.Enter:Console.Beep(200,100); break;
                }
                if (x < 0) x = 0;
                if (y < 0) y = 0;
                if (x == 0 || y == 0) Console.Beep();
            } while (key != ConsoleKey.Escape);
        }
    }
}
