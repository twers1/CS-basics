using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light
{
    internal class Program
    {


        static void Main(string[] args)
        {
            // Генератор случайных чисел от нуля до 9 

            Random rand = new Random();
            //int value = rand.Next(0, 10);

            //while(true)
            //{
            //    value = rand.Next(0, 10);
            //    Console.WriteLine("Случайное число от 1 до 10: " +value);
            //    Console.ReadKey();
            //}

            // Создание игры "Угадай число"

            //int number;
            //int lower, higher;
            //int triesCount = 5;
            //int userInput;

            //number = rand.Next(0, 101);
            //lower = rand.Next((number - 10), number);
            //higher = rand.Next((number + 1), (number + 10));

            //Console.WriteLine($"Мы загадали число от 0 до 100, оно больше, чем {lower}, но меньше, чем {higher}."); // интерпретация

            //Console.WriteLine($"Что это за число? У вас {triesCount} попыток отгадать.");

            //while (triesCount-- > 0)
            //{
            //    Console.Write("Ваш ответ: ");
            //    userInput = Convert.ToInt32(Console.ReadLine());

            //    if (userInput == number)
            //    {
            //        Console.WriteLine("Вы правы, это было число " + number);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Неверно. Попробуйте еще раз!");
            //    }

            //    if (triesCount == 0)
            //    {
            //        Console.WriteLine("Вы проиграли, но не переживайте - повезет в следующий раз. Это было число: " + number);
            //    }
            //}

            // Хитрости работы с консолью 



            //Console.SetCursorPosition(5, 10);
            //Console.ForegroundColor = ConsoleColor.DarkCyan; // меняет цвет текста
            //Console.BackgroundColor = ConsoleColor.DarkGray; // меняет фон текста
            //Console.Clear(); // перекрасит фон в darkgray

            //Console.WindowHeight = 10;
            //Console.WindowWidth = 35;

            //Console.WriteLine("Привет! Куда ты вчера делся?\n Я убежал к...]\b \b");

            //Console.ReadKey();

            int[] sectors = { 6, 28, 15, 15, 17 };
            bool isOpen = true;

            while (isOpen)
            {
                // Покупка авиабилетов: 

                Console.SetCursorPosition(0, 18);

                for (int i = 0; i < sectors.Length; i++)
                {
                    Console.WriteLine($"В секторе {i + 1} свободно {sectors[i]} мест. ");
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Регистрация рейса.");
                Console.WriteLine("\n \n1 - забронировать места \n \n2 - выход из программы\n\n");
                Console.Write("Введите номер команды:");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userSector, userPlaceAmount;
                        Console.Write("В каком секторе вы хотите лететь? ");
                        userSector = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (sectors.Length <= userSector || userSector < 0)
                        {
                            Console.WriteLine("Такого сектора не существует");
                            break;
                        }
                        Console.Write("Сколько мест вы хотите забронировать? ");
                        userPlaceAmount = Convert.ToInt32(Console.ReadLine());
                        if (userPlaceAmount < 0)
                        {
                            Console.WriteLine("Неверно количество мест.");
                            break;
                        }
                        if (sectors[userSector] < userPlaceAmount)
                        {
                            Console.WriteLine($"В секторе {userSector} недостаточно мест. Остаток {sectors[userSector]}");
                            break;
                        }
                        sectors[userSector] -= userPlaceAmount;
                        Console.WriteLine("Бронирование успешно!");

                        break;
                    case 2:
                        isOpen = false;
                        break;
                }
            }
        }
    }
}

