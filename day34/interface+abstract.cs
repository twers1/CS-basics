using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.CodeDom;
using System.Threading;

namespace para
{
    // Интерфейс + abstract
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

            player.CheckInfo(new Box());
        }
    }

    interface IMassInfo
    {
        void ShowInfo();
    }

    interface IWeapon
    {
        int Damage { get; }
        void Fire();
    }


    abstract class Weapon : IMassInfo, IWeapon
    {
        public abstract int Damage { get; }
        public abstract void Fire();

        public void ShowInfo()
        {
            Console.WriteLine(GetType().Name);
        }
    }

    class Box : IMassInfo
    {
        public void ShowInfo()
        {
            Console.WriteLine("Я коробка!");
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
        public void Fire(IWeapon weapon)
        {
            weapon.Fire();
        }

        public void CheckInfo(IMassInfo massinfo)
        {
            massinfo.ShowInfo();
        }

        
    }







}
