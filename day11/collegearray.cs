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
            int a = 0, b = 0;
            //Бинарная операция
            int c = a + b;
            //Унарная операция
            a++;
            //Пример с использованием if() else
            //int a1 = int.Parse(Console.ReadLine());
            //int a2 = 0;
            //if (a1 >= 0)
            //{
            //    a2 = a1;
            //}else
            //{
            //    a2 = 0;
            //}
            //Тернарный оператор
            // (условие) ? if_true : if_false
            Console.WriteLine("Введите число:");
            int inputData = int.Parse(Console.ReadLine());
            int outputData = (inputData >= 0) ? inputData : 0;
            Console.WriteLine("Ответ: " + outputData);
            Console.ReadLine();
            /////////////////////////////////////////////////
            //Массивы
            //1 вариант создания массива
            int[] arr = { 1, 2, 3, 4, 5, 3, 5, 3, 5, 3, 5 };
            //2 вариант создания массива
            // new- выделяет память 
            Console.WriteLine("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[3];
            arr1[0] = 2;
            arr1[1] = 3;
            arr1[2] = 9;
            //Заполнение массива с помощью цикла for()
            int[] arr2 = new int[n];

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine("Введите элемент массива: ");
                arr2[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Элемент массива: " + i + " " + arr2[i]);

            }
            //Двухмерные массивы
            //1 вариант
            int[,] arr3 =
            {
                {1,2,3,4,5},
                {2,3,4,5,7},
                {1,2,3,4,5}
            };
            //2 вариант
            int[,] arr4 = new int[2, 2];

            //Console.WriteLine("Длина массива arr4= "+arr4.Length);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Введите элемент массива: ");
                    arr4[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //Вывод элементов двумерного массива с помощью вложенного цикла for()
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Введите элемент массива: " + i + " " + j + " " + arr4[i, j]);

                }
            }

            // Вывод элементов массива с помощью цикла foreach()
            foreach (int x in arr4)
            {
                Console.Write(" Элемент= " + x);
            }
        }
        }
    }

