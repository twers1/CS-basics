using System;
using System.ComponentModel.Design.Serialization;

namespace properties
{
    // const и readonly
    class Program 
    {
        
        static void Main(string[] args)
        {
            Car car = new Car(new MyLogger());
            car.Drive();
            car.StartEngine();
            car.StartEngine();
            car.Drive();
            
        }
       
    }

    
    class MyLogger
    {
      public void Info(string message)
       {
            Console.WriteLine($"{DateTime.Now}\t|INFO|\t{message}");
       }
     public void Error(string message)
        {
            Console.WriteLine($"{DateTime.Now}\t|ERROR|\t{message}");
        }
        public void Warn(string message)
        {
            Console.WriteLine($"{DateTime.Now}\t|WARN|\t{message}");
        }
    }

    class Car
    {
        private const string ENGINE_IS_STARTED_MESSAGE = "Двигатель запущен!";
        private const string ATTEMPT_TO_START_ENGINE_MESSAGE = "Завожу двигатель!";
        private const string ENGINE_HAS_ALREADY_STARTED_MESSAGE = "Лапоть, двигатель уже запущен!";
        private const string ATTEMPT_TO_DRIVE_MESSAGE = "Тапку в пол!";
        private const string DRIVE_MESSAGE = "Поехали!";
        private const string DRIVE_ERROR_MESSAGE = "Лапоть, сначала заведи двигатель!";

        private readonly MyLogger _myLogger; // мы не будем менять данное поле, это некий сервис, который будет использовать Car для своих нужд

        private bool isEngineStarted; // статус машины(заведен или нет)

        public Car(MyLogger myLogger)
        {
            _myLogger = myLogger;
        }


        public void StartEngine()
        {
            _myLogger.Info(ATTEMPT_TO_START_ENGINE_MESSAGE);
            if(isEngineStarted)
            {
                _myLogger.Warn(ENGINE_HAS_ALREADY_STARTED_MESSAGE);
            }
            else
            {
                isEngineStarted = true;
                _myLogger.Info(ENGINE_IS_STARTED_MESSAGE);
            }
        }

        public void Drive()
        {
            _myLogger.Info(ATTEMPT_TO_DRIVE_MESSAGE);
            if (isEngineStarted)
            {
                _myLogger.Info(DRIVE_MESSAGE);
            }
            else
            {
                _myLogger.Error(DRIVE_ERROR_MESSAGE);
            }
        }
    }

    

    
   

   

    
    

   
     

    

   
}
