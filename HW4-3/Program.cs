using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_3
{


    class Program
    {
        enum Seasons
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");
            int numMounth = Convert.ToInt32(Console.ReadLine());

            if (numMounth > 0 && numMounth < 13)
                Console.WriteLine("Это " + EnumSeasonToString(MounthToSeason(numMounth)));
            else
                Console.WriteLine("Ошибка: введите число от 1 до 12"); 
            
            Console.ReadLine();
        }

        static Seasons MounthToSeason(int mounth)
        {
            Seasons result=0;

            if (mounth == 12 || mounth == 1 || mounth == 2)
                result = Seasons.Winter;
            if (mounth >2 && mounth < 6)
                result = Seasons.Spring;
            if (mounth > 5 && mounth < 9)
                result = Seasons.Summer;
            if (mounth > 8 && mounth < 12)
                result = Seasons.Autumn;
            return result;
        }

        static string EnumSeasonToString(Seasons season)
        {
            string result = "";
            switch (season)
            {
                case Seasons.Winter:
                    result = "Зима";
                    break;
                case Seasons.Spring:
                    result = "Весна";
                    break;
                case Seasons.Summer:
                    result = "Осень";
                    break;
                case Seasons.Autumn:
                    result = "Осень";
                    break;
            }
            return result;
        }
    }

}
