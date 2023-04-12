using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace properties
{
   // модификаторы доступа public и private
    class Program 
    {
        static void Main(string[] args)
        {
            Point point = new Point();

            point.PrintY();
            point.PrintPoint();

            var typeInfo = typeof(Point).GetFields(BindingFlags.Instance |
                BindingFlags.NonPublic |
                BindingFlags.Public);

            foreach (var item in typeInfo)
            {
                Console.WriteLine($"{item.Name}\t isPrivate: {item.IsPrivate}\t isPublic:{item.IsPublic}");
            }
        }
    }

    class Point
    {
        // с помощью таких моментов, где что-то у нас доступно, а что-то нет
        //  то у нас образуется инкапсуляция
        int z = 3; // если мы не указали модификатор доступа для какого-то объекта, он по умолчанию будет private 
        public int x =1;
        private int y = 44;

        private void PrintX()
        {
            Console.WriteLine($"X: {x}");
        }

        public void PrintY()
        {
            Console.WriteLine($"Y: {y}");
        }

        public void PrintPoint()
        {
            PrintX();
            PrintY();
        }
    }

    

   
}
