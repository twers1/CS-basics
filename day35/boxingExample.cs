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
    // boxing and unboxing | упаковка и распаковка значимых типов

    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point { X= 0, Y = 0 };
            Print(point);

        }

        static void Print(IPrintable printable)
        {
            printable.Print();
        }
    }

    interface IPrintable
    {
        void Print();
    }

    struct Point : IPrintable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public void Print()
        {
            Console.WriteLine($"X: {X}\tY: {Y}");
        }
    }
    

   



}








