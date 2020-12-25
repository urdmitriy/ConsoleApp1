using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            Proc MyProcess = new Proc();
            MyProcess.FillProcessList();
            MyProcess.PrintProccList();

            bool killResult = false;

            while (!killResult)
            {
                int idKillProc = 0;
                Console.WriteLine("Какой процесс (ID) желаете грохнуть?");

                try
                {
                    idKillProc = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Не удалось получить ID процесса");
                }
                
                killResult = MyProcess.KillProcess(idKillProc);
                if (!killResult) Console.WriteLine("Еще разок");
            }
            
            Console.ReadLine();
        }
    }
}
