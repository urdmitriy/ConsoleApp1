using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mass = new int[10, 10];

            //заполнение массива
            for (int y = 0; y < mass.GetLength(0); y++)
            {
                for (int x = 0; x < mass.GetLength(1); x++)
                {
                    mass[y, x] = y * 10 + x;
                }
            }

            //вывод данных по диагонали
            for (int n=0;n<mass.GetLength(0);n++)
            {
                Console.Write($"{mass[n, n]} ");
            }
            Console.ReadLine();
        }
    }
}
