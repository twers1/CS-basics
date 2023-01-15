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
            // Условия ( Пример 1)
            int age;
            Console.Write("Введите свой возраст: ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Добро пожаловать в наш бар?");
                Console.WriteLine("Что будете пить?");
            }
            else
            {
                Console.WriteLine("Вы слишком юны");
                Console.WriteLine("Приходите к нам через: " + (18 - age)+ " лет.");
            }


            // Пример 2 
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode; 

            string dayOfWeek;
            Console.WriteLine("Введите день недели: ");
            dayOfWeek = Console.ReadLine();

            if (dayOfWeek == "Понедельник")
            {
                Console.WriteLine("Проходим курсы");
            }

            else if (dayOfWeek == "Вторник")
            {
                Console.WriteLine("Делаем домашнее задание");
            }
        }
    }
}
