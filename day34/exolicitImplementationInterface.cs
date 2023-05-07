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
    // Явная реализация интерфейсов
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();
            Foo(myclass);
            Bar(myclass);

            MyOtherClass myOtherClass = new MyOtherClass();
            Foo(myOtherClass);
            Bar(myOtherClass);

            // приведение к типу интерфейса

            // 1 способ
            ((IFirstInterface)myOtherClass).Action();
            ((ISecondInterfce)myOtherClass).Action();

            // 2 способ (такой нужно использовать)
            if(myOtherClass is IFirstInterface firstInterface)
            {
                firstInterface.Action();
            }
           
        }

        static void Foo(IFirstInterface firstInterface)
        {
            firstInterface.Action();
        }

        static void Bar(ISecondInterfce secondInterfce) 
        {
            secondInterfce.Action();
        }
    }

    interface IFirstInterface
    {
        void Action();
    }

    interface ISecondInterfce
    {
        void Action();
    }

    class MyClass : IFirstInterface, ISecondInterfce
    {
        public void Action()
        {
            Console.WriteLine("My class Actions...");
        }
    }

    class MyOtherClass : IFirstInterface, ISecondInterfce
    {
        void IFirstInterface.Action()
        {
            Console.WriteLine("MyOtherClass first...");
        }

        void ISecondInterfce.Action()
        {
            Console.WriteLine("MyOtherClass second...");
        }
    }



}








