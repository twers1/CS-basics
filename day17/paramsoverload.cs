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
            //Console.WriteLine(Sum(900,200,"Проверяю условие"));
            //int[] arr = new int[10];
            //arr[0] = 1;
            //arr[3] = 20;
            //int result = Sum1(1, 2, 3, 4, 5, 34, 3, 3, 4, 56, 3, 5, 3, 5);
            //Console.WriteLine(result);
        }





        //Перегрузка методов
        public static int Sum()
        {
            return 0;
        }
        /// <summary>
        /// Считает сумму двух входящих параметров
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Метод считает сумму входящих параметров и возвращает 1000, если их сумма >1000
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int Sum(int a, int b, string s)
        {
            Console.WriteLine(s);
            if (a + b > 1000)
            {
                return 1000;
            }
            return a + b;
        }
        public static int Sum(int a)
        {

            return a + 120;
        }

        //Params
        public static int Sum1(params int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        //пример использования params с дополнительными параметрами
        //public static int Sum1(string s, double d, params int[] array)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        sum += array[i];
        //    }

        //    return sum;
        //}
        //Object
        public static void PrintObject(params Object[] array)
        {

            foreach (var item in array)
            {
                Console.WriteLine(item.GetType());
            }

        }
    }
}

