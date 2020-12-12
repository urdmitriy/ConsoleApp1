using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер текущего месяца");
            int mounthN = Convert.ToInt32(Console.ReadLine());
            string mounthW = null;
            switch (mounthN)
            {
                case 1:
                    mounthW = "Январь";
                    break;
                case 2:
                    mounthW = "Февраль";
                    break;
                case 3:
                    mounthW = "Март";
                    break;
                case 4:
                    mounthW = "Апрель";
                    break;
                case 5:
                    mounthW = "Май";
                    break;
                case 6:
                    mounthW = "Июнь";
                    break;
                case 7:
                    mounthW = "Июль";
                    break;
                case 8:
                    mounthW = "Август";
                    break;
                case 9:
                    mounthW = "Сентябрь";
                    break;
                case 10:
                    mounthW = "Октябрь";
                    break;
                case 11:
                    mounthW = "Ноябрь";
                    break;
                case 12:
                    mounthW = "Декабрь";
                    break;
                default:
                    mounthW = "Введено неверное значение";
                    break;
            }
            Console.WriteLine($"Вы ввели месяц: {mounthW}");
            Console.ReadLine();
        }
    }
}
