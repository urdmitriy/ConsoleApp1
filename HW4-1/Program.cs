using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((GetFullName("Дмитрий", "Урюпин", "Анатольевич")));
            Console.WriteLine((GetFullName("Иван", "Дукалис", "Васильевич")));
            Console.WriteLine((GetFullName("Евгений", "Кактус", "Федорович")));
            Console.WriteLine((GetFullName("Владимир", "Шток", "Владимирович")));

            Console.ReadLine();
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return firstName + " " + patronymic + " " + lastName;
        }

  
    }
}
