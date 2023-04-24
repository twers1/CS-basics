using System;

namespace properties
{
    // Ключевое слово static. Статический класс
    class Program 
    {
        
        static void Main(string[] args)
        {

            MyClass.Foo();
            MyClass.Bar();
            
        }
       
    }

    // статический класс должен быть объявлен в модификаторе static(все поля, методы и конструктор)
    static class MyClass
    {
        static MyClass()
        {
            // мы не можем использовать this, так как это ссылка на объект 
        }
        public static void Foo()
        {
            Console.WriteLine("Foo");
        }

        public static void Bar()
        {
            Console.WriteLine("Bar");
        }

        static int a;
    }

    

    
   

   

    
    

   
     

    

   
}
