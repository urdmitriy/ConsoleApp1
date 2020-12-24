using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текс для сохранения в файл");
            string data = Console.ReadLine();
            string filename = "dataFile.txt";
            File.WriteAllText(filename, data);
        }
    }
}
