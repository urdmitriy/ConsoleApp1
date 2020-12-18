using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] mass = new char[10, 10]
            {
                {'O','O','O','O','O','O','O','O','O','O',},
                {'O','X','O','X','X','O','X','X','X','O',},
                {'O','O','O','O','O','O','O','O','O','O',},
                {'O','O','O','O','O','X','O','O','X','O',},
                {'O','X','O','X','O','X','O','O','O','O',},
                {'O','O','O','X','O','O','O','O','X','O',},
                {'O','O','O','X','O','O','O','O','X','O',},
                {'O','O','O','X','O','X','X','O','X','O',},
                {'O','O','O','O','O','O','O','O','O','O',},
                {'O','O','O','O','X','O','O','O','O','O',},
            };

            for (int y=0; y < mass.GetLength(0); y++)
            {
                for (int x = 0; x < mass.GetLength(1); x++)
                {
                    Console.Write($"{mass[y, x]} ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
