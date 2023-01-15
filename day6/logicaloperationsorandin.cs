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
            // Логическое И и ИЛИ; И == &&; ИЛИ == ||
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            int money = 500;
            int level = 10;

            if (money >= 500 || level > 9)
            {
                Console.WriteLine("Проходи! Добро пожаловать в нашу гильдию");
            }
            else
            {
                Console.WriteLine("Вас выпнули за дверь!");
            }

            
        }
    }
}
