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

            string s, s1;
            Console.WriteLine("Введите строку: ");

            //Сonsole.Readline() -считывает в консоли ввод с клавиатуры 
            //в формате строки
            s = Console.ReadLine();
            s1 = Console.ReadLine();

            //Convert.ToInt32() - конвертирует строку в тот тип данных, который
            //вы укажете.
            int a = Convert.ToInt32(s);
            int b = Convert.ToInt32(s1);

            //Считывание данных сразу в переменную.
            int c = Convert.ToInt32(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            double d1 = Convert.ToDouble(s);
            Console.WriteLine("Результат= " + s);

        }
    }
}
