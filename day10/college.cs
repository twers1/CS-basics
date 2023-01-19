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
            // Цикл while

            int i = 0; 
            while (i<5)
            {
                Console.WriteLine(i);
                i++;
            }

            while (true)
            {
                Console.WriteLine("Вечный цикл");
            }

            int number;
            do
            {
                Console.WriteLine("Введите число 5");
                number = Convert.ToInt32(Console.ReadLine());
            }
            while (number != 5);
        }
    }
}
