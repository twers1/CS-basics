using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace properties
{
   // конструктор класса - это специальный метод, который используется для создания объекта

    class Program 
    {
        static void Main(string[] args)
        {
            Point point = new Point(5, 3);
            point.Print();
            
        }
    }

   
    class Point
    {
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }
        private int _x;
        private int _y;

        public void Print()
        {
            Console.WriteLine($"X: {_x}\tY: {_y}");
        }
        
    }

    

   
}
