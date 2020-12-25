using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = DateTime.Now.ToShortTimeString();
            string fileName = "startup.txt";
            File.AppendAllText(fileName, time);
            File.AppendAllText(fileName, Environment.NewLine);
        }
    }
}
