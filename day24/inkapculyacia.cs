using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace properties
{
   // Инкапсуляция
    class Program 
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun();
            gun.Shoot();
        }
    }

   
    class Gun
    {
        // состояние - это переменные, и у нас только одна переменная в классе
        private bool isLoaded;
        private void Reload()
        {
            Console.WriteLine("Заряжаю... ");
            isLoaded = true;
            Console.WriteLine("Заряжено!");
        }
        public void Shoot()
        {
            if (!isLoaded)
            {
                Console.WriteLine("Орудие не заряжено!");
                Reload();
            }
            Console.WriteLine("Пыщ - пыщ\n");
            isLoaded = false;
        }
    }

    

   
}
