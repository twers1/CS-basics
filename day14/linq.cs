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
            int[] myArray = { 111, 10, 4, 111, 49, 64, 77, 4, 49, 5 };
            int result;
            //Мин и макс
            //Console.WriteLine(myArray.Min());
            //int result = myArray.Min();

            //Console.WriteLine(myArray.Max());
            //result = myArray.Max();

            //Сумма
            //result = myArray.Sum();
            //Console.WriteLine(myArray.Sum());

            //Использование метода Where()
            //самое маленькое нечетное число, четное и тд.
            //result = myArray.Where(i => i % 2 == 0).Sum();
            //result = myArray.Where(i => i % 2 == 0).Min();
            //result = myArray.Where(i => i % 2 != 0).Max();

            //Выбрать уникальные элементы из массива
            //int[] newArr = myArray.Distinct().ToArray();
            //foreach (var item in newArr)
            //{
            //    Console.WriteLine(item);
            //}

            //Сортировка массива OrderBy()
            //int[] newArr = myArray.OrderBy(i => i).ToArray();

            //int[] newArr = myArray.OrderByDescending(i => i).ToArray();

            //использование статических методов и свойств класса Array

            //Sort
            //Array.Sort(myArray);

            //foreach (var item in myArray)
            //{
            //    Console.WriteLine(item);
            //}

            //Метод Find()-выводит первый элемент, удовлетворяющий условию
            //result = Array.Find(myArray, i => i < 70);
            ////Console.WriteLine(result);
            //Метод FindLast()-выводит первый элемент, удовлетворяющий условию c конца
            //result = Array.FindLast(myArray, i => i < 70);
            //Console.WriteLine(result);
            //FindAll() ищет все элементы, удовлетворяющие условию
            //int[] res = Array.FindAll(myArray, i => i < 70);
            //Console.WriteLine(result);
            //FindIndex() - ищем индекс первого элемента, удовлетворяющего условию
            //result = Array.FindIndex(myArray, i => i == 77);
            //Console.WriteLine(result);
            //Ищем индекс с конца
            //result = Array.FindLastIndex(myArray, i => i == 70);
            //Console.WriteLine(result);
            //Реверс массива
            //Array.Reverse(myArray);
            //foreach (var item in myArray)
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadLine();
        }
    }
}

