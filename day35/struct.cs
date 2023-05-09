using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.CodeDom;
using System.Threading;
using System.Buffers;

namespace para
{
    // Структуры
    // оно схожа с классами, только она является значимым типом и не умеет наследоваться
    class Program
    {
        static void Main(string[] args)
        {
            ClassPoint classPoint = new ClassPoint();

            StructPoint structPoint = new StructPoint();
            Console.WriteLine(structPoint.X);

            Foo(classPoint);
            Bar(structPoint);

        }

        static void Foo(ClassPoint classPoint)
        {
            classPoint.X++;
            classPoint.Y++;
        }

        static void Bar(StructPoint structPoint)
        {
            structPoint.Y++;
            structPoint.X++; 
        }

    }
    // классы хранятся в управляемой куче, а структуры хранятся в стеке

    public class ClassPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Print()
        {
            Console.WriteLine($"X: {X}\tY: {Y}");
        }

        // сборщик мусора
        ~ClassPoint()
        {

        }
    }

    public struct StructPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Print() 
        {
            Console.WriteLine($"X: {X}\tY: {Y}");
        }
    }



}








