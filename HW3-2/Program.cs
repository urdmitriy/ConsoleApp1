using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] phoneBook = new string[5, 2] {
                                                        {"Ivan","+79998887777"},
                                                        { "Vasiliy","vasya@yandex.ru"},
                                                        { "Aleksandr","+78889996655"},
                                                        { "Sergey","seriy@gmail.com"},
                                                        { "Anna","+72223332211"},
            };

            Console.WriteLine("Телефонная книга:");
            for (int i = 0; i< phoneBook.GetLength(0); i++)
            {
                Console.WriteLine($"Имя: {phoneBook[i, 0]}, телефон/емайл: {phoneBook[i, 1]}");
            }

            Console.ReadLine();
        }

    }
}
