using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру");
            string tempMin = Console.ReadLine();
            Console.WriteLine("Введите максимальную температуру");
            string tempMax = Console.ReadLine();
            double avTemp = Math.Round(((Convert.ToDouble(tempMin) + Convert.ToDouble(tempMax)) / 2),2);
            Console.WriteLine($"Средняя температура: {avTemp} градусов");
            Console.ReadLine();
        }
    }
}
