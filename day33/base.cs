using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.CodeDom;
using System.Threading;

namespace para
{
    // наследование, конструкторы класса и ключевое слово base
    class Program
    {
        static void Main(string[] args)
        {
            Point3D point3D = new Point3D(3,3,3);
            Point2D point2D = new Point2D(2,3);
            point3D.Print3D();
            
        }
    }

    class Point2D : Object
    {
        public Point2D(int x, int y)
        {
            Console.WriteLine("Вызван конструктор Point2D");
            X = x; Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }

        public void Print2D()
        {
            Console.WriteLine("X: \t" +X);
            Console.WriteLine("Y: \t" + Y);
        }
    }

    class Point3D : Point2D
    {
        // чтобы не было ошибки из-за параметров - нам потребуется ключевое слово base
        // ключевое слово base явно указывает на то, что мы хотим использовать что-то из базового класса(в классе наследника)
        // ключевые слова this и base схожи, но this используется в самом классе(текущем) и это ссылка на объект
        public Point3D(int x, int y, int z): base(x,y)
        {
            Z = z;
            Console.WriteLine("Вызван конструктор Point3D");
        }
        public int Z { get; set; }

        public void Print3D()
        {
            base.Print2D();
            Console.WriteLine("Z: \t" + Z);
        }
    }
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Вызван конструктор MyClass");
        }
    }
}
