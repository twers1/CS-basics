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
            //Циклы
            //a- счетчик
            int a = 0;
            bool boo = true;
            //b- ограничитель
            Console.WriteLine("Введите количество итераций:");
            int b = int.Parse(Console.ReadLine());

            //В скобках while() - Лоигическое значение/ переменная и 
            //логические выражения

            while (true)
            {
                Console.WriteLine("Шаг" + a);
                a++;

                if (a == b)
                {
                    break;
                }

            }
            Console.WriteLine("Мы вышли из цикла!");
            //пример с использованием переменной bool
            a = 0;
            while (boo)
            {
                Console.WriteLine("Шаг" + a);
                a++;
                if (a == b)
                {
                    boo = false;
                }

            }
            Console.WriteLine("Мы вышли из цикла!");
            // Пример с использованием проверки условий
            // > < >= <= != == (&& || !)
            a = 0;
            while (a < 10)
            {
                Console.WriteLine("Привет" + a);
                a++;
            }
            //Цикл while() без тела
            int i = 0, j = 500;
            while (++i < --j) ;
            Console.WriteLine("среднее значение i и j= " + i);

            a = 0;
            //do {} while();  Цикл do while
            do
            {
                Console.WriteLine("Шаг" + a);
                a++;

            }
            while (false);
            Console.WriteLine("Мы вышли из цикла!");
        }
    }
}
