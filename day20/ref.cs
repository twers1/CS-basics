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
            //int a = 2;

            //Foo(ref a);

            //Console.WriteLine(a);

            int[] myArray = { 1, 4, 6 };

            Bar(ref myArray);

            Console.WriteLine();

            int[] arr = { 2, 6, 1 };

            ref int b = ref arr[0]; // ссылочная локальная переменная

            b = -5;
        }

        static void Foo( int a )
        {
            a = -5;
        }

        static void Bar(ref int[] arr)
        {
            // myArray[0] = -5;
            // arr = null; // с помощью такой операции, мы разорвем связь ссылки с управляемой кучей(мы потеряем доступ к данным,
            // которые ссылаются имя массива myArray и  больше не сможем ничего с ними не сделаем, поэтому сборщик мусора ОП очистит

            arr = new int[10]; 
        }

        static ref int Foo(int[] numbers)
        {
            return ref numbers[0]; 
        }
    }
}
