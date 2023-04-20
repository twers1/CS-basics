using System;

namespace properties
{
    // Частичные типы. Partial классы и методы
    // наш класс с помощью partial становится частичным(мы его разбиваем на части)
    class Program 
    {
        
        static void Main(string[] args)
        {
            Person person = new Person("sdads", "dad dasda");
            person.PrintFullName();
        }
       
    }

    partial class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        


    }

    partial class Person
    {
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine(GetFullName());
        }
    }

    

   
     

    

   
}
