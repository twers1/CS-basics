using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
  // класс позволяет нам различную информацию определенного рода удобно объединить в одном месте и использовать в  одном объекте
    class Program 
    {
        static Student GetStudent()
        {
            var student = new Student();

            student.firstName = "Мартин";
            student.middleName = "Игоревич";
            student.lastName = "Дугин";
            student.age = 19;
            student.id = Guid.NewGuid();
            student.group = "ИС4243";

            return student;
        }
        static void Print(Student student)
        {
            Console.WriteLine("Информация о студенте: ");
            Console.WriteLine($"Id: {student.id}");
            Console.WriteLine($"Фамилия:{student.lastName }");
            Console.WriteLine($"Имя:{student.firstName }");
            Console.WriteLine($"Отчество: {student.middleName }");
            Console.WriteLine($"Возраст: {student.age }");
            Console.WriteLine($"Группа: {student.group }");
        }
        static void Main(string[] args)
        {
            var firstStudent = GetStudent();

            Print(firstStudent);
        }
    }

    class Student 
    {
        public Guid id;// guid - тип данных уникальных id
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group;
    }
}
