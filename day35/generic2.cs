using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.CodeDom;
using System.Threading;
using System.Buffers;
using System.Collections;

namespace para
{
    // Обобщения (Generics) | производительность | коллекции | list vs arraylist

    

    class Program
    {
        static void Main(string[] args)
        {
            // обобщенные коллекции работают быстрее 

            
        }
        
    }

    public static class SwapTestClass
    {
        public static void GenericSwap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static void Swap(ref object a, ref object b)
        {
            object temp = a;
            a = b;
            b = temp;
        }
    }

}








