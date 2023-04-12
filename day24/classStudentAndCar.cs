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
        static void Main(string[] args)
        {
            var firstStudent = GetStudent();

            // firstStudent.Print();

            var secondStudent = GetStudent();
            secondStudent.firstName = "noname";
            secondStudent.Print();

            string fullName = firstStudent.GetFullName();

            Console.WriteLine("\t== Car 1 ==");
            var car = new Car();
            car.PrintSpeed();
            car.DriveForward();
            car.PrintSpeed();
            car.Stop();
            car.PrintSpeed();

            Console.WriteLine("\t== Car 2 ==");
            var car2 = new Car();
            car2.PrintSpeed();
            car2.DriveBackward();
            car2.PrintSpeed();
        }
    }

    class Student 
    {
        public Guid id;
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group;

        public void Print()
        {
            Console.WriteLine("Информация о студенте: ");
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Фамилия:{lastName}");
            Console.WriteLine($"Имя:{firstName}");
            Console.WriteLine($"Отчество: {middleName}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Группа: {group}");
        }

        public string GetFullName()
        {
            return $"{lastName} {firstName} {middleName}";
        }
    }

    class Car
    {
        private int speed = 0;
        public void PrintSpeed()
        {
            if(speed == 0)
            {
                Console.WriteLine("Стоим на месте...");
            }
            if(speed > 0)
            {
                Console.WriteLine($"Едем вперед со скоростью {speed} км/ч");
            }
            if(speed < 0)
            {
                Console.WriteLine($"Едем назад со скоростью {-speed} км/ч");
            }
        }
        public void DriveForward()
        {
            speed = 60;
        }
        public void Stop()
        {
            speed = 0;
        }
        public void DriveBackward()
        {
            speed = -5;
        }

    }
}
