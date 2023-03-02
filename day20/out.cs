using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Light
{
    // для структурных типов данных подойдет больше ключевое слово ref, так как он значимый тип данных, а не ссылочный
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Bar(out a);

            Console.WriteLine(a);
        }

       static void Bar(out int value)
        {
            value = 5;
            Console.WriteLine(value); // когда мы используем ключевое слово OUT, мы обязаны передать значение переменной, которая
            // находится внутри метода

            string str = Console.ReadLine();
            int.TryParse(str, out int result);

            Console.WriteLine(result);
        }
    }
}
