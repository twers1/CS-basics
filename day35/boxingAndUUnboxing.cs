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
            int a = 1;
            object b = a; // операция упаковка 
            int c = (int)b; // операция распаковка 

            // decimal d = (decimal)b; // будет ошибка

        }

        

    }
    

   



}








