using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите фразу");
            string phrase = Console.ReadLine();
            char[] reversePhrase = new char[phrase.Length];

            for (int n = 0; n < phrase.Length; n++)
            {
                reversePhrase[n] = phrase[phrase.Length - 1 - n];
            }

            Console.Write("Фраза наоборот: ");
            for (int n = 0; n < reversePhrase.Length; n++)
            {
                Console.Write(reversePhrase[n]);
            }

            Console.ReadLine();
        }
    }
}
