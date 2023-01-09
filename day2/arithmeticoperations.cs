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
            // + - * / %
            float result; // int result 

            int x;
            int y;

            x = 5;
            y = 2;

            result = Convert.ToSingle(x) / y; // чтобы получить более правильный ответ, то мы должны одну из цифр консертировать в ту сингл, чтобы x стала float'ом
            Console.WriteLine(result); // 2

            // Деление по модулю 
            int timeInMinets = 130;
            int hour;
            int minute;

            hour = timeInMinets/ 60;
            minute = timeInMinets % 60;

            Console.WriteLine("hours:" + hour);
            Console.WriteLine("minuets:" + minute);

            // Приколюха
            int age = 18;

            age = age + 1;
            age++;
            age += 1;
            // Это можно сделать и с умножением, с делением, и с минусом
        }
    }
}
