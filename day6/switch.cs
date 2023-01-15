using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light
{
    internal class Program
    {
  

        static void Main(string[] args)
        {
            // Условный оператор Switch

            string dayOfWeek;
            dayOfWeek = Console.ReadLine();

            switch (dayOfWeek)
            {
                case "понедельник":
                    Console.WriteLine("Идем в кино");
                    Console.WriteLine("Едим попкорн");
                    break;
                case "вторник":
                    Console.WriteLine("Проходим курсы");
                    break;
                case "среда":
                    Console.WriteLine("Изучаем switch");
                    break;
                case "четверг":
                    Console.WriteLine("Проектируем проект");
                    break;
                case "пятница":
                    Console.WriteLine("Делаем игру");
                    break;
                case "суббота":
                    Console.WriteLine("Отдыхаем");
                    break;
                case "воскресенье":
                    Console.WriteLine("Отдыхаем");
                    break;
                default:
                    Console.WriteLine("Я такого дня не знаю!");
                    break;
            }

            
        }
    }
}
