using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    internal class Program
    {
        static void Main()
        {
            // Предполагается, что у тебя уже есть:
            // const int Size = 7;
            // char[,] map = new char[Size, Size];      // 'L' — суша, 'S' — море, 'R' — риф
            // int[,] goldMap = new int[Size, Size];
            // var rnd = new Random();

            int treasureI = -1, treasureJ = -1;

            // Ищем случайную сухопутную клетку, пока не найдём
            while (true)
            {
                int r = rnd.Next(Size);
                int c = rnd.Next(Size);

                // Клад можно спрятать только на суше (не на рифах и не в море)
                if (map[r, c] == 'L')
                {
                    treasureI = r;
                    treasureJ = c;

                    // Ставим маркер клада
                    map[r, c] = 'X';

                    // Присваиваем ценность
                    goldMap[r, c] = 1000;

                    break;
                }
            }

            Console.WriteLine($"Клад спрятан в клетке [{treasureI}, {treasureJ}]");
        }
    }
}
