using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для какого числа рассчитать число Фибоначчи?");
            Console.WriteLine("Ответ: " + GetPhibonachchi(Convert.ToInt32(Console.ReadLine())));
            Console.ReadKey();
        }

        static int GetPhibonachchi(int number)
        {
            if (number == 0) return 0;
            if (number == 1 || number == 2) return 1;

            return GetPhibonachchi(number - 1) + GetPhibonachchi(number - 2);
        }
    }
}
