using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.CodeDom;
using System.Threading;
using System.Buffers;
using System.Collections;

namespace para
{
    // Обобщения (Generics) 

    // они позволяют писать код для разных типов данных
    // обобщения помогают избежать распаковку и упаковку типов данных

    class Program
    {
        static void Main(string[] args)
        {
            // обобщенные коллекции и классы
            List<int> list = new List<int>();
            list.Add(1);
            Console.WriteLine(list[0]);
            list[0] = 2;

            // необобщенные коллекции 
            ArrayList list1 = new ArrayList();
            list1.Add(2);
            list1.Add("asdads");

            // проверка нашего созданного обобщенного класса 

            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            
        }
        // создаем самостоятельный обобщенный класс

        public class MyList<T>
        {
            // private T[] array = new T[0]; // так не нужно делать, так как
            // каждый раз когда мы будет создавать объект лист, у нас будет выделяться память в управляемой куче
            // под массив, который никогда не сможем использовать, так как в нем 0 элементов 
            // но если мы будем использовать метод Empty - будет происходить то же самое,
            // // только он возвращает ссылку на статическое поле Array
            // тут мы будем использовать меньше памяти, потому что она вызовется один раз
            private T[] _array = Array.Empty<T>();

            public T this[int index]
            {
                get
                {
                    return _array[index];
                }
                set
                {
                    _array[index] = value;
                }
            }

            public int Count { get { return _array.Length; } }

            public void Add(T value)
            {
                var newArray = new T[_array.Length + 1];

                for (int i = 0; i < _array.Length; i++)
                {
                    newArray[i] = _array[i];
                }
                newArray[_array.Length] = value;

                _array = newArray;
            }
        }


        
    }


}








