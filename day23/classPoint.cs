using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    enum Color
    {
        Red,
        Green,
        Yellow,
        Blue,
        Orange
    }

    class Program // класс - это ссылочный тип данных
    {
        static void Main(string[] args)
        {
            // p - это экземпляр класса
            Point p = new Point(); // теперь у каждого экземпляра свои поля x и y
            p.x = 4; // и они лежат в разной области ОП, и они между собой вообще не связаны
            p.y = 2;

            // p = null; доказательства о том, что класс ссылочный тип



            Point p2 = new Point();
            p2.y = 2;
            p2.x = 6;
            p2.color = Color.Red;

            // любой объект в языке c# является наследником типа данных Object

            Console.WriteLine($"X: {p2.x} | Y: {p2.y} | Color: {p2.color} ");
        }
    }

    class Point // класс - это наш собственный тип данных, это наш шаблон, схема по которой мы будем строить дом 
    {
        public int x; // переменная x - это поле класса, и у каждого поля класса есть свой модификатор доступа
        public int y;
        public Color color;
    }
}
