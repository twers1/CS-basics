using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.CodeDom;
using System.Threading;

namespace para
{
    // приведение типов и наследование. Использование операторов as и is
    class Program
    {
        static void Main(string[] args)
        {
            // Object и object - это одно и то же
           object obj = new Point { X = 3, Y= 4 }; // любой производный тип можно сохранить в ссылке базового класса
            // тип данных object - базовый класс для всех типов данных

            MyClass obj2 = new Point { Y = 5, X = 3 };

            // Небезопасный способ 
            Point point = (Point)obj;
            point.Print2D();

            Foo(obj);
            Bar(obj);
            
        }

        // пример использования оператора as
        static void Foo(object obj)
        {
            // мы с помощью оператора as преобразовываем наш объект типа данных object в тип point
            // разница с преобразованием  Point point = (Point)obj такова: если в тип данных передать что-то иное, а не point, то такое преобразование 
            // вызывает ошибку, а если мы используем оператор as, то таких исключений не будет.
            // Читает это так: Если в obj действительно был тип данных Point, то у нас все будет без исключений
            Point point = obj as Point;

            if(point !=null)
            {
                point.Print2D();
            }
        }

        // пример использования оператора is
        static void Bar(object obj)
        {
            // Изначально оператор is просто позволял проверить тип данных, которые у нас находятся в переменной

            //if(obj is Point) 
            //{
            //    Point point = (Point)obj;
            //    point.Print2D();
            //}

            // в таком случае, нам этот способ не годится, потому что мы могли бы с таким успехом использoвать оператор as, 
            // а то в этом случае, мы сначала передаем параметр, потом его же записываем в условие, но в 7 версии c# оператор is 
            // прокачали, добавили новые возможности, такие как: 

            if(obj is Point point)
            {
                point.Print2D();
            }
        }

    }

    class MyClass
    {

    }

    class Point :MyClass
    {
        
        public int X { get; set; }
        public int Y { get; set; }

        public void Print2D()
        {
            Console.WriteLine("X: \t" +X);
            Console.WriteLine("Y: \t" + Y);
        }
    }

   
}
