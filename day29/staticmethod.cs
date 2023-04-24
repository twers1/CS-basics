using System;

namespace properties
{
    // Ключевое слово static. Статистические методы класса. Свойства класса
  
    class Program 
    {
        
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyClass.Foo();
            myClass.Bar();

            MyClass.B = 3;
            myClass.A = 4;

            
        }
       
    }

    class MyClass
    {
        private static int a;

        public int A
        {
            get { return a; }
            set { a = value; }
        }


        public static int B { get; set; }

        public static void Foo()
        {
            Console.WriteLine("Вызван метод Foo");
            a = 5;
            Console.WriteLine(a);
            // мы не можем сюда написать метод Bar и переменную b, а если в нестатическом методе
            // вызвать метод статический, то он будет работать, так как находятся в одном классе 
        }

        public void Bar()
        {
            Console.WriteLine("Вызван метод Bar");
            Foo();
        }
    }

    
   

   

    
    

   
     

    

   
}
