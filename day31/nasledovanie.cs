using System;
using System.ComponentModel.Design.Serialization;
using System.Net.Cache;

namespace properties
{
    // наследование
    class Program
    {

        static void Main(string[] args)
        {
            Person person = new Person
            {
                firstName = "dafafa",
                lastName = "dafafa"
            };

            person.PrintName();

            Student student = new Student
            {
                firstName = "dafaf",
                lastName = "adada"
            };

            student.PrintName();
            student.info();

            Person student2 = new Student
            {
                firstName = "dafa",
                lastName = "dafs"
            };

            PrintFullName(student);

        }

        static void PrintFullName(Person person)
        {
            Console.WriteLine($"Фамилия: {person.lastName}\t {person.firstName}");
        }

    }

    // наследование ооп - это инструмент, который позволяет избежать ненужного дублирование кода
   class Person
    {
        public string lastName { get; set; }
        public string firstName { get; set; }

        public void PrintName()
        {
            Console.WriteLine($"Меня зовут {firstName}");
        }
    }

    class Student : Person
    {
        public void info()
        {
            Console.WriteLine("Я учусь");
        }
    }



















}
