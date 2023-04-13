using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;

namespace properties
{
   // перегрузка конструкторов класса
    class Program 
    {
        static void Main(string[] args)
        {
            Student student = new Student("аыав", new DateTime(2000, 10, 5));
            student.Print();
            student.SetLastName("DADS") ;

            Student student2 = new Student(student);
            student2.Print();
            
        }
    }

   
    class Student
    {
        public Student(string lastName, DateTime birtday)
        {
            _lastName = lastName;
            _birthday = birtday;
        }

        public Student(string lastName, string firstName, string middleName, DateTime birtday)        
        {
            _firstName = firstName;
            _lastName = lastName;
            _middleName = lastName;
            _birthday = birtday;

        }
        public Student(Student student)
        {
            _firstName = student._firstName;
            _middleName = student._middleName;
            _lastName = student._lastName;
            _birthday = student._birthday;
        }

        public  void SetLastName(string lastName)
        {
            _lastName = lastName;
        }
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private DateTime _birthday;

        public void Print()
        {
            Console.WriteLine($"{_firstName} {_lastName} {_middleName} {_birthday}");
        }
        
    }

    

   
}
