using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardChess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер шахматной доски: ");
            int boardSize = Convert.ToInt32(Console.ReadLine());
            const int cubeSize = 5;
            for (int boardRow = 0; boardRow < boardSize; boardRow++)
            {
                for (int lineInCube = 0; lineInCube < cubeSize; lineInCube++)
                {
                    string currentLine = "";
                    for (int boardCol = 0; boardCol < boardSize; boardCol++)
                    {
                        string cubePart = ((boardRow + boardCol) % 2 == 0)
                            ? new string('#', cubeSize)
                            : new string(' ', cubeSize);
                        currentLine += cubePart;
                    }
                    Console.WriteLine(currentLine);
                }
            }
        }
    }
}
