using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace properties
{
   // конструктор класса - это специальный метод, который используется для создания объекта

    class Program 
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun(false);
            Gun gun2 = new Gun(isLoaded:true);
            gun.Shoot();
            
        }
    }

   
    class Gun
    {
        // ctor + tab2(создание констуктора)

        /* данный конструктор по умолчанию
         public Gun()
        {
            // isLoaded = true;
            Reload();
        }
        */
        // данный конструктор с параметрами
        public Gun(bool isLoaded)
        {
            _isLoaded = isLoaded;
            // this.isLoaded = isLoaded; // this - обращается к той переменной, которая является полем класса 
        }
        // состояние - это переменные, и у нас только одна переменная в классе
        private bool _isLoaded;
        private void Reload()
        {
            Console.WriteLine("Заряжаю... ");
            _isLoaded = true;
            Console.WriteLine("Заряжено!");
        }
        public void Shoot()
        {
            if (!_isLoaded)
            {
                Console.WriteLine("Орудие не заряжено!");
                Reload();
            }
            Console.WriteLine("Пыщ - пыщ\n");
            _isLoaded = false;
        }
    }

    

   
}
