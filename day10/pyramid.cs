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
            // Треугольник
            Console.WriteLine("Введите высоту треугольника: ");
            int a = int.Parse(Console.ReadLine());

            for (int i =0; i <a; i++)
            {
                for (int j = 0; j <a-i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k<=i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
