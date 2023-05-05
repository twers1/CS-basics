using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.CodeDom;
using System.Threading;

namespace para
{
    // абстрактные классы, методы, свойства
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Gun gun = new Gun();

            Weapon[] inventory =
            {
                new Gun(),
                new LaserGun(),
                new FireBall()
            };
        }
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

    class Gun : Weapon
    {
        public override int Damage => 8;
        public override void Fire()
        {
            Console.WriteLine("Пыщ!");
        }
    }

    class LaserGun : Weapon
    {
        public override int Damage => 3;

        public override void Fire()
        {
            Console.WriteLine("лазер");
        }
    }

    class FireBall : Weapon
    {
        public override int Damage => 3;
        public override void Fire()
        {
            Console.WriteLine("огненный шар");
        }
    }

    class Player
    {
        public void Fire(Weapon weapon)
        {
            weapon.Fire();
        }

        public void CheckInfo(Weapon weapon)
        {
            weapon.ShowInfo();
        }
    }
}
