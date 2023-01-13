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
            // Действия (консоль)
            Console.WriteLine();
            Console.ReadKey(); // консоль ждет нас ввода любой клавиши

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            string name;
            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine(); // ждем пока пользователь сам введет свою информацию 
            Console.WriteLine($"Ваше имя: {name}"); // sw 2 tab -> console.writeline()

            int age;
            Console.Write("Введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваш возраст: {age} лет");
        }
    }
}
