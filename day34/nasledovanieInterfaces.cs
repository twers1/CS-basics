using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.CodeDom;
using System.Threading;
using System.Buffers;

namespace para
{
    // Наследование интерфейсов
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Gun gun = new Gun();

            IInterface interface1; // когда мы наследовали от одного интерфейса, то все его методы, свойства будут доступны и этому новому интерфейсу(если мы наследовали)

            IWeapon[] inventory = { new Gun(), new LaserGun() , new Knife()};

            foreach (var item in inventory)
            {
                player.Fire(item);
                Console.WriteLine();
            }

            player.Throw(new Knife());
           
        }
    }

    
    // доступно множественное наследование интерфейсов
    interface IWeapon
    {
        
        void Fire();
    }

    interface IInterface : IWeapon
    {
        void Foo();
    }

    interface IThrowingWeapon : IWeapon
    {
        void Throw();
    }


    abstract class Weapon
    {
        public abstract int Damage { get; }
        public abstract void Fire();

        public void ShowInfo()
        {
            Console.WriteLine(GetType().Name);
        }
    }

    

    class Gun : IWeapon
    {
       
        public  void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Пыщ!");
        }
    }

    class LaserGun : IWeapon
    {
       

        public void Fire()
        {
            Console.WriteLine("лазер");
        }
    }

    class Knife : IThrowingWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Хыщ!");
        }

        public void Throw()
        {
            Console.WriteLine($"{GetType().Name}: Фьють!");
        }
    }

    class Player
    {
        public void Fire(IWeapon weapon)
        {
            weapon.Fire();
        }

        public void Throw(IThrowingWeapon throwingWeapon)
        {
            throwingWeapon.Throw();
        } 
    }







}
