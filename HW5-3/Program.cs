using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числa от 0 до 255 через пробел");
            string data = Console.ReadLine();
            string fileName = "data.bin";
            string[] dataArrayString = data.Split(' ');
            byte[] dataArrayByte = new byte[dataArrayString.Length];
            for (int i = 0; i < dataArrayString.Length; i++)
            {
                dataArrayByte[i] = byte.Parse(dataArrayString[i]);
            }
            File.WriteAllBytes(fileName, dataArrayByte);
        }
    }
}
