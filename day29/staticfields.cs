using System;

namespace properties
{
    // Ключевое слово static. Статистические поля класса
  
    class Program 
    {
        
        static void Main(string[] args)
        {
            // Создаем экземпляры классов
            // 1 пример
           MyClass myClass1 = new MyClass();
           myClass1.a = 44;

            MyClass myClass2 = new MyClass();
            myClass2.a = 22;

            MyClass.b = 1;

            // 2 пример

            MyClass2 myClass22 = new MyClass2();
            myClass22.SetB(1);

            MyClass2 myClass12 = new MyClass2();
            myClass12.PrintB();
        }
       
    }

    // Статистические поля класса. Создание и примеры
    class MyClass
    {
        public int a;
        // Статистическая переменная общая для всех экземпляров класса, также и объем оперативной памяти
        public static int b;
    }

    class MyClass2
    {
        private static int b;

        public void SetB(int b)
        {
            MyClass2.b = b;
        }

        public void PrintB()
        {
            Console.WriteLine(b);
        }
    }

   

   

    
    

   
     

    

   
}
