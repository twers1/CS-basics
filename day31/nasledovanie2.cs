using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.CodeDom;
using System.Threading;

namespace properties
{
    // наследование
    class Program
    {

        static void Main(string[] args)
        {
            
        }

        static void PrintPersons(Person[] people)
        {
            foreach (var person in people)
            {
                person.PrintFullName();
            }
        }
        // примечание, классы не могут унаследовать множество классов


    }

    
    class Person
    {
        public string lastName { get; set; }
        public string firstName { get; set; }

        public void PrintFullName()
        {
            Console.WriteLine($"Меня зовут {firstName}\t Моя фамилия {lastName}");
        }
    } 

    class Student : Person
    {
        public void info()
        {
            Console.WriteLine("Я учусь");
        }
    }

    class Employee : Person
    {
        public decimal Salary { get; set; }
    }

    class Security : Employee
    {
        public void Guard()
        {
            Console.WriteLine("я охраняю");
        }
    }

    class Teacher : Employee
    {
        public void Teach()
        {
            Console.WriteLine("Я учу!");
        }
    }



















}
