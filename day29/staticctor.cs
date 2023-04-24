using System;

namespace properties
{
    // Ключевое слово static. Статический конструктор 
  
    class Program 
    {
        
        static void Main(string[] args)
        {
           MyClass myClass1 = new MyClass();
            new MyClass();
            new MyClass();
            new MyClass();
            MyClass.Foo();

            
        }
       
    }

    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Конструктор");
        }
        // статический конструктор - это конструктор, отвечающий только за параметр static.
        // и он в одном классе должен быть единственным, то есть, мы не сможем использовать перегрузку

        static MyClass()
        {
            Console.WriteLine("Статический конструктор");
        }

        public static void Foo()
        {
            Console.WriteLine("Foo");
        }
    }

    
   

   

    
    

   
     

    

   
}
