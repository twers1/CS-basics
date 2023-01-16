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
            //Приведение типов данных
            double d = 2.5;
            int a = 5;
            byte b = 2;

            //Явное приведение типов данных
            //(тип_данных)имя_переменной
            //b = (byte)a;
            d = (double)a / b;
            Console.WriteLine(d);
            //String - строки
            string s = "ПРИВЕТ!";
            string s1 = "Андрей";
            //Length - возвращает длину строки посимвольно
            a = s.Length;
            //Equals- сравнивает две строки
            Console.WriteLine(s.Equals(s1));
            s.Equals(s1);
            //Верхний регистр/ нижний регистр
            //ToUpper/ ToLower
            Console.WriteLine(s.ToLower());
            //contains- метод, который позволяет узнать есть ли
            //какой либо символ в строке
            Console.WriteLine(s.Contains('И'));
            //IndexOf()- находит индекс символа в строке
            Console.WriteLine(s1.IndexOf('в'));
            string s3 = s + s1;
            Console.WriteLine(s3);
            //Условные операторы
            bool boo = true;
            //В скобках If может быть любой оператор сравнения,
            //метод, который возвращает значение типа bool
            //Логический тип
            //операторы == , !=, <, >, >=, <=
            if (5 < 6)
            {
                Console.WriteLine("Условие выполнилось");
            }
            else if (boo)
            {
                Console.WriteLine("Условие не выполнилось");
                boo = false;
            }
            else if (boo)
            {
                Console.WriteLine("Условие не выполнилось");
            }
            else
            {
                Console.WriteLine("Условие не выполнилось");
            }
            // Операторы логической алгебры
            // &&- Логическое И, ||- логическое ИЛИ, !- логическое НЕ
            if (5 < 6 && 6 > 10 && 10 < 20 || a == 9)
            {
                Console.WriteLine("Привет мир!");
            }
            else
            {
                Console.WriteLine("Условие не выполнилось");
            }

            //оператор switch
            //Внутри скобок switch может быть:Любая переменная 
            a = 4;
            switch (a)
            {
                case 1:
                    Console.WriteLine("Вы нажали 1");
                    break;
                case 2:
                    Console.WriteLine("Вы нажали 2");
                    break;
                case 3:
                    Console.WriteLine("Вы нажали 3");
                    break;
                case 4:
                    Console.WriteLine("Вы нажали 4");
                    break;
                case 7:
                    Console.WriteLine("Вы нажали 7");
                    break;
                default:
                    Console.WriteLine("Ни одно условие не выполнилось!");
                    break;

            }


        }
    }
}
