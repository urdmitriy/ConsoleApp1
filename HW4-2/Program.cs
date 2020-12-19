using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел:");
            string inputString = Console.ReadLine();
            string[] inputMass = inputString.Split(new char[] {' '});

            int summ=0;

            for (int i = 0; i < inputMass.Length; i++)
            {
                summ += Convert.ToInt32(inputMass[i]);
            }

            Console.WriteLine($"Сумма значений: {summ}");

            Console.ReadLine();
        }
    }
}
