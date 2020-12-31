using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Properties.Settings.Default.greeting);
            if (string.IsNullOrEmpty(Properties.Settings.Default.userName))
            {
                Console.WriteLine("Введите ваше имя");
                Properties.Settings.Default.userName = Console.ReadLine();
                Console.WriteLine("Введите ваш возраст");
                Properties.Settings.Default.age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Чем занимаетесь?");
                Properties.Settings.Default.work = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            else
            {
                Console.WriteLine($"Вас зовут {Properties.Settings.Default.userName}, " +
                    $"вам {Properties.Settings.Default.age} лет, " +
                    $"вы занимаетесь {Properties.Settings.Default.work}");
            }
            

            Console.ReadLine();
        }
    }
}
