using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру");
            string tempMin = Console.ReadLine();
            Console.WriteLine("Введите максимальную температуру");
            string tempMax = Console.ReadLine();
            double avTemp = Math.Round(((Convert.ToDouble(tempMin) + Convert.ToDouble(tempMax)) / 2), 2);

            Console.WriteLine("Введите порядковый номер текущего месяца");
            int mounthN = Convert.ToInt32(Console.ReadLine());

            if ((mounthN == 12 || mounthN == 1 || mounthN == 2) && avTemp > 0)
                Console.WriteLine("Дождливая зима");
            Console.ReadLine();
        }
    }
}
