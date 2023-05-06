using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.CodeDom;
using System.Threading;

namespace para
{
    // Полиморфизм, виртуальные методы, модификаторы: virtual, override
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();

            person.Drive(new Car());
            person.Drive(new SportCar());

            
            
        }
    }

    // Если мы хотим, чтобы в нашем базовом классе метод Drive работал по другому, то полиморфизм предоставляет данную возможность
    // и с помощью ключевых слов virtual и override
    class Car
    {
        // переопределить данных метод можно с помощью ключевого слова virtual
        public virtual void Drive()
        {
            Console.WriteLine("Я машина, я еду!");
        }
    }

    class Person
    {
        public void Drive(Car car)
        {
            car.Drive();
        }
    }

    class SportCar : Car
    {
        // для того, чтобы уже написать свой метод и переписать его, нам нужно уже другое ключевое слово - override
        public override void Drive()
        {
            Console.WriteLine("Я еду очень быстро");
        }
    }

    
    

   
}
