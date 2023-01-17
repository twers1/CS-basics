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

            Console.WriteLine("Добро пожаловать в калькулятор!");
            double a, b;
            string c;

            Console.WriteLine("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Что будете делать? +, -, *, /");
            c = Console.ReadLine();

            if (c == "+")
            {
                Console.WriteLine("Результат со сложением: " + (a + b));
            }
            else if (c == "-")
            {
                Console.WriteLine("Результат с вычитанием: " + (a - b));
            }
            else if (c == "*")
            {
                Console.WriteLine("Результат с умножением: " + (a * b));
            }
            else if (c == "/")
            {
                Console.WriteLine("Результат с делением: " + (a / b));
            }
            else
            {
                Console.WriteLine("Выбрана неверная операция");
            }
        }
    }
}
