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
            // Лабораторная работа 1 (задание 2; 1)


            int[] array = new int[10];
            Console.WriteLine("Введи мне произвольный размер массива(10 чисел)");
            for (int i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine()); // пользователь вводит числа, которые будут находится в массиве
            }
            int min = array[0]; // переменная min присваивается значение, которое равен нулю
            for (int i = 0; i < 10; i++)

            {
                if (array[i] < min)
                {
                    min = array[i];

                }
            }
            int max = array[9];
            for (int i = 0; i < 10; i++)
            {

                if (array[i] > max)
                {
                    max = array[i];

                }
            }
            Console.WriteLine("Минимальное число: {0}", min);
            Console.WriteLine("Максимальное число: {0}", max);
            Console.WriteLine("Сумма максимального и минимального числа: " + (min + max));

            // Задание 2 (2)
            Random rand = new Random();

            int[,] array2 = new int[5, 5];

            Console.WriteLine("Введи мне произвольный размер двумерного массива 5 на 5");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array2[i, j] = rand.Next(0, 10);
                }
            }
            Console.WriteLine("Вывод таблицы: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("{0}\t", array2[i, j]);
                }
            }


            // Задание 2 (3)

            int[] array3 = new int[10];
            Console.WriteLine("Введи мне произвольный размер массива(10 чисел)");

            for (int i = 0; i < 10; i++)
            {
                array3[i] = Convert.ToInt32(Console.ReadLine()); // пользователь вводит числа, которые будут находится в массиве
            }

            int print = (array3[0] + array3[1] + array3[2] + array3[3] + array3[4] + array3[5] + array3[6] + array3[7] + array3[8] + array3[9]) / array3.Length;
            Console.WriteLine("Среднее арифметическое значение чисел в массиве: " + print);
        }
    }
}

