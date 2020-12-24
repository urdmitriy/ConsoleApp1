using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace HW5_5
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("Работа со списком задач. 1-Вывести список задач, 2-Создать задачу");
            string answer = Console.ReadLine();

            if (answer == "1")
            {
                //вывод списка задач
                while (true) 
                {
                    Console.Clear();
                    printTasks("task.json");
                }
                
            }
            else if (answer == "2")
            {
                //создание задачи
                while(true)
                { 
                    createTask("task.json"); 
                }
                
            }

            Console.ReadLine();



        }
        static void printTasks(string fileName)
        {
            string[] json = File.ReadAllLines(fileName);

            ToDo[] task = new ToDo[json.Length];

            for (int i = 0; i < json.Length; i++)
            {
                task[i] = JsonSerializer.Deserialize<ToDo>(json[i]);
                string done = task[i].getIsDone() ? "[X]" : "";
                Console.WriteLine($"#{i}  {done} {task[i].getTitle()}");
            }

            Console.WriteLine("Какую задачу пометить как выполненную?");
            int taskForCorrect = Convert.ToInt32(Console.ReadLine());

            if (taskForCorrect >= 0 && taskForCorrect < json.Length)
            {
                task[taskForCorrect].setDone();

                //очищаем файл
                File.WriteAllText(fileName, "");

                for (int i = 0; i < json.Length; i++)
                {
                    string jsonWr = JsonSerializer.Serialize(task[i]);
                    File.AppendAllText(fileName, jsonWr + Environment.NewLine);
                }
            }

        }
        static void createTask(string fileName)
        {
            Console.WriteLine("Укажите название задачи");
            ToDo newTask = new ToDo(Console.ReadLine());
            string json = JsonSerializer.Serialize(newTask);
            File.AppendAllText(fileName, json + Environment.NewLine);
        }
    }
}
