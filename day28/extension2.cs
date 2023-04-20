using System;

namespace properties
{
    // Методы расширения. Extension методы.
    class Program 
    {
        
        static void Main(string[] args)
        {
            Student student = new Student() { FirstName = "Мартин", LastName = "Дугин" };

            string fullName = student.GetFullName();
        }
       
    }

    // sealed - мы не можем унаследовать данный класс
    sealed class Student
    {
        // класс с двумя полями
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    static class MyExtensions
    {
        public static string GetFullName(this Student student)
        {
            return student.LastName + " " + student.FirstName;
        }
    }

   
     

    

   
}
