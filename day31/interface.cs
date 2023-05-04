using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.CodeDom;
using System.Threading;

namespace para
{
    // интерфейс и полиморфизм

    // данные 
    interface IDataProvider
    {
        // все интерфейсы имеют публичный модификатор и они являются абстрактными
        string GetData();
    }

    interface IDataProcessor
    {
        void ProcessData(IDataProvider dataProvider);
    }

    // реализуем интерфейс
    class ConsoleDataProcessor : IDataProcessor
    {
        public void ProcessData(IDataProvider dataProvider)
        {
            Console.WriteLine(dataProvider.GetData());
        }
    }

    class DbDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из БД";
        }
    }

    class FileDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из файлов";
        }
    }

    class APIDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из айпи";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IDataProcessor dataProcessor = new ConsoleDataProcessor();
            dataProcessor.ProcessData(new APIDataProvider());
            dataProcessor.ProcessData(new FileDataProvider());
            dataProcessor.ProcessData(new DbDataProvider());
        }
    }
}
