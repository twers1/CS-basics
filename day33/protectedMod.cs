using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.CodeDom;
using System.Threading;

namespace para
{
    // модификатор доступа protected при наследовании
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();

            B b = new B();
            

            
            
        }
    }

    class A
    {
        public int publicFiled;

        private int privateFiled2;
        
        protected int protectedFiled3;

        private protected int privateFiled4;

        // вписать модификатор доступа protected можно и в методах, в конструкторах, в свойствах 

        public A()
        {
            Console.WriteLine(publicFiled);
            Console.WriteLine(privateFiled2);
            Console.WriteLine(protectedFiled3);
        }

        public void Foo()
        {
            Console.WriteLine(publicFiled);
            Console.WriteLine(privateFiled2);
            Console.WriteLine(protectedFiled3);
        }
    }

    class B : A
    {
        // модификатор protected нужен для того, чтобы работать с классами наследниками
        public B()
        {
            Console.WriteLine(publicFiled);
            Console.WriteLine(protectedFiled3);
        }
    }
    

   
}
