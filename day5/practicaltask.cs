using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light
{
    internal class Program
    {
  

        static void Main(string[] args)
        {
            // Практическое задание (1 пример)
            float health;
            int armor;
            int damage;

            // Ctrl + D -> скопировать то, что надо и вставить  
            Console.Write("Введите количество здоровья: ");
            health = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество брони: ");
            armor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество урона: ");
            damage = Convert.ToInt32(Console.ReadLine());

            health -= Convert.ToSingle(damage) / 100 * armor; // 100 - магическое число(процент)

            Console.WriteLine($"Вам нанесли {damage} урона. У вас осталось {health} здоровья"); // используем интерполяцию 


            // Практическое задание (2 пример)
            int money;
            int food;
            int foodUnitPrice = 10;
            // Заведем булевую переменную, чтобы в магазине не быть в долгах 
            bool isAbleToPay;

            Console.WriteLine("Добро пожаловать в пекарню! Сегодня еда по " + foodUnitPrice + " монет.");

            Console.WriteLine("Сколько у вас денег?");
            money = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сколько еды вам нужно?");
            food = Convert.ToInt32(Console.ReadLine());

            isAbleToPay = money >= food * foodUnitPrice;
            food *= Convert.ToInt32(isAbleToPay); // если isabletopay будет равно true, то продолжиться выполняться след действие
            money -= food * foodUnitPrice;
            Console.WriteLine($"У вас в сумке {food} единиц еды и {money} денег.");

        }
    }
}
