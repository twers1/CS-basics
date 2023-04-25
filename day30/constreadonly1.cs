using System;
using System.ComponentModel.Design.Serialization;

namespace properties
{
    // const и readonly
    class Program 
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(MyClass.PI);
            MyClass myClass = new MyClass(3);
            myClass.Foo();

            
            
        }
       
    }

    
    class MyClass
    {
        private const int a = 2; // модификатор const позволяет сделать так, чтобы у нас не было возможности 
        // изменить данную переменную 
        public const string MY_EERROR = "some error";
        public const double PI = 3.14;
        // присвоить другие значения в const не получится
        // const == static

        public readonly int b; // readonly не является static, но можем его сделать статическим
        // readonly инициализируется только в конструкторах или же в полях класса
        public static readonly int _b; // чтобы инициализировать static поле, мы должны иметь доступ к конструктору, у которого модификатор static

        public MyClass(int b)
        {
            this.b = b;
        }
        public void Foo()
        {
            Console.WriteLine(MY_EERROR);
            Console.WriteLine(PI);
        }
    }

    

    
   

   

    
    

   
     

    

   
}
