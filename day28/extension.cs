using System;

namespace properties
{
    // Методы расширения. Extension методы.
    class Program 
    {
        // методы расширения должны находится в static класса и сами должны быть статистическими
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            currentDateTime.Print();
            // также можем так вызвать
            DateTime.Now.Print();

            DateTime currentWeek = DateTime.Now;
            Console.WriteLine(currentWeek.IsDayOfWeek(DayOfWeek.Thursday));
        }
       
    }

    static class MyExtensions
    {
        public static void Print(this DateTime dateTime)
        {
            Console.WriteLine(dateTime);
        }

        public static bool IsDayOfWeek(this DateTime dateTime, DayOfWeek dayOfWeek) 
        {
            return dateTime.DayOfWeek == dayOfWeek; 
        }
    }

   
     

    

   
}
