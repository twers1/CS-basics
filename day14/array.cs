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
            //Заполнение массива случайными числами
            Random random = new Random();
            int[] arr = new int[5];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = random.Next(100);
            //}

            //foreach (var item in a)
            //{
            //    Console.WriteLine(item);
            //}
            int[,] arr1 = new int[3, 4];
            int[,,] arr2 = new int[3, 2, 2];
            //Метод для определения количества измерений Rank();
            //Console.WriteLine(arr.Rank);
            //Console.WriteLine(arr1.Rank);
            //Console.WriteLine(arr2.Rank);
            // GetLength()- метод, возвращающий размер указанного измерения массива
            // нумерация измерений начинается с 0 
            //for (int i = 0; i <arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j <arr1.GetLength(1); j++)
            //    {
            //        arr1[i, j] = random.Next(10,30);
            //    }

            //}
            //foreach (var item in arr1)
            //{
            //    Console.WriteLine(item);
            //}

            //Многомерные массивы 4-х мерный массив(книга)
            int[,,,] arr4D = new int[2, 4, 3, 4];
            Console.WriteLine(arr4D.Rank);

            arr4D[0, 3, 2, 0] = 10;
            //Заполнение массива
            for (int i = 0; i < arr4D.GetLength(0); i++)
            {
                //Console.WriteLine("== Книга "+(i+1)+" ==");

                for (int j = 0; j < arr4D.GetLength(1); j++)
                {
                    // Console.WriteLine("== Страница " + (j + 1) + " ==");
                    for (int k = 0; k < arr4D.GetLength(2); k++)
                    {
                        for (int q = 0; q < arr4D.GetLength(3); q++)
                        {
                            arr4D[i, j, k, q] = random.Next(30);
                        }

                    }

                }


            }
            for (int i = 0; i < arr4D.GetLength(0); i++)
            {
                Console.WriteLine("== Книга " + (i + 1) + " ==");

                for (int j = 0; j < arr4D.GetLength(1); j++)
                {
                    Console.WriteLine("== Страница " + (j + 1) + " ==");
                    for (int k = 0; k < arr4D.GetLength(2); k++)
                    {
                        for (int q = 0; q < arr4D.GetLength(3); q++)
                        {
                            Console.Write(arr4D[i, j, k, q] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
            //Зубчатые массивы
            int[][] arr3 = new int[3][];
            arr3[0] = new int[4];
            arr3[1] = new int[5];
            arr3[2] = new int[2];
            Console.WriteLine(arr3.Rank);
            //Что можем делать
            int[] arr4 = arr3[0];
            //Заполнение
            for (int i = 0; i < arr3.Length; i++)
            {
                for (int j = 0; j < arr3[i].Length; j++)
                {
                    arr3[i][j] = random.Next(100);
                }
            }
        }
    }
}

