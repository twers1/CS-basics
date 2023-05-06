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

    // пример использования полиморфизма и модификаторов доступа
    class Car
    {
        protected virtual void StartEngine()
        {
            Console.WriteLine("Двигатель запущен! ");
        }
        public virtual void Drive()
        {
            StartEngine();
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
        protected override void StartEngine()
        {
            Console.WriteLine("Рон! Дон! Дон!");
        }
        public override void Drive()
        {
            StartEngine();
            Console.WriteLine("Я еду очень быстро");
        }
    }

    
    

   
}
