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
            int a, b;

            Console.WriteLine("Добро пожаловать в операторы сравнения");

            Console.WriteLine("Введите первое число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Большее число: " + a);
            }
            else
            {
                Console.WriteLine("Наименьшее число: " + a);
            }

            Console.WriteLine("Четность/нечетность числа");

            if (a%2 == 0)
            {
                Console.WriteLine("Это четное число: " + a);
            }
            else
            {
                Console.WriteLine("Это нечетное число: " + b);
            }
            
        }
    }
}
