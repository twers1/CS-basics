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
            // Лабораторная работа 1 (задание 2; 1)


            int[] array = new int[10];
            int sum = 0;
            Console.WriteLine("Введи мне произвольный размер массива(10 чисел)");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine()); // пользователь вводит числа, которые будут находится в массиве
            }
            int min = array[0]; // переменная min присваивается значение, которое равен нулю
            for (int i = 0; i < array.Length; i++)

            {
                if (array[i] < min)
                {
                    min = array[i];


                }
                sum += array[i];
            }
            int max = array[9];
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] > max)
                {
                    max = array[i];

                }
            }
            Console.WriteLine("Минимальное число: {0}", min);
            Console.WriteLine("Максимальное число: {0}", max);
            Console.WriteLine("Сумма всех элементов: " + sum);

            // Задание 2 (2)

            Console.WriteLine("Введи размер таблицы: ");

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] array2 = new int[m, n];

            Console.WriteLine("Введите мне элементы: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Вывод таблицы: ");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", array2[i, j]);
                }
            }


            // Задание 2 (3)

            int[] array3 = new int[10];
            // int sum = 0; - уже есть данная переменная в первом задании
            Console.WriteLine("Введи мне произвольный размер массива(10 чисел)");

            for (int i = 0; i < 10; i++)
            {
                array3[i] = Convert.ToInt32(Console.ReadLine()); // пользователь вводит числа, которые будут находится в массиве
                sum+= array3[i];
            }

            int print = sum / array3.Length;
            Console.WriteLine("Среднее арифметическое значение чисел в массиве: " + print);
        }
    }
}

