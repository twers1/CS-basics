using System;

namespace properties
{
    // Ключевое слово static. Статистические методы класса. Свойства класса
  
    class Program 
    {
        
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyClass myClass2 = new MyClass();
            MyClass myClass3 = new MyClass();

            Console.WriteLine(MyClass.Counter);

            Console.WriteLine(MyClass.GetCounter());

            myClass3.GetObjectsCounter();
            

            
        }
       
    }

    class MyClass
    {
        public MyClass()
        {
            Counter++;
        }
        
        private static int counter;

        public static int Counter
        {
            get { return counter; }
            private set { counter = value; } // private нужен для того, чтобы сохранить инкапсуляцию
        }

        

        public int ObjectsCount
        {
            get { return counter; }
        }


        public static int GetCounter()
        {
            return counter;
        }

        public int GetObjectsCounter()
        {
            return counter;
        }

    }

    
   

   

    
    

   
     

    

   
}
