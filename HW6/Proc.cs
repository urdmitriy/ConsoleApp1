using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HW6
{
    class Proc
    {
        public Process[] process { get; private set; }

        public void FillProcessList()
        {
            process = Process.GetProcesses();
        }
        public void PrintProccList()
        {
            for (int i = 0; i < process.Length; i++)
            {
                Console.WriteLine($"[{process[i].Id}]\t{process[i].ProcessName}");
            }
        }

        public bool KillProcess(int id)
        {
            try
            {
                Process.GetProcessById(id).Kill();
            }
            catch (Exception)
            {
                Console.WriteLine("Не удалось удалить указанный процесс");
                return false;
            }
            Console.WriteLine("Процесс завершен успешно");
            return true;
        }
    }
}
