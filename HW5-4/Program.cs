using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь для начала сканирования");
            string pathScan = Path.Combine(Console.ReadLine());

            Console.WriteLine("Рекурсивно? (1-да, 0-нет)");
            
            bool recourse;
            string answer = Console.ReadLine();

            if (answer == "1") 
                recourse = true; 
            else 
                recourse = false; 

            string fileName = "List.txt";

            File.WriteAllText(fileName, "Перечень файлов и папок:");
            File.AppendAllText(fileName, Environment.NewLine);

            printListDirAndFiles(pathScan, fileName, ref recourse);
            Console.WriteLine("===================Enter - выход======================");
            Console.ReadLine();
        }

        static void printListDirAndFiles(string path, string fileName, ref bool recourse)
        {
            string pathScan = Path.Combine(path);
            string[] dirList = Directory.GetDirectories(pathScan);
            

            for (int i = 0; i < dirList.Length; i++)
            {
                File.AppendAllText(fileName, dirList[i] + Environment.NewLine);
                Console.WriteLine(dirList[i]);

                if (recourse)
                {
                    string[] fileList = Directory.GetFiles(dirList[i]);

                    for (int j = 0; j < fileList.Length; j++)
                    {
                        File.AppendAllText(fileName, fileList[j] + Environment.NewLine);
                        Console.WriteLine(fileList[j]);
                    }

                    printListDirAndFiles(dirList[i], fileName, ref recourse);
                }
            }

            if (!recourse)
            {
                string[] fileList = Directory.GetFiles(pathScan);
                for (int i = 0; i < fileList.Length; i++)
                {
                    File.AppendAllText(fileName, fileList[i] + Environment.NewLine);
                    Console.WriteLine(fileList[i]);
                }
            }
            
        }
    }
}
