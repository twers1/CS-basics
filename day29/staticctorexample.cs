using System;

namespace properties
{
    // Ключевое слово static. Статический конструктор 
  // статический конструктор - это специальный метод, где мы можем инициализировать статические данные 
    class Program 
    {
        
        static void Main(string[] args)
        {
           DbRepository db= new DbRepository();
            db.GetData();
            
        }
       
    }

    class DbRepository
    {
        private static string connectionString;
        static DbRepository()
        {
            ConfigurationManager configurationManager = new ConfigurationManager();
            connectionString = configurationManager.GetConnectionString(); 
        }

        public void GetData()
        {
            Console.WriteLine("Использую: " + connectionString);
        }
    }

    class ConfigurationManager
    {
        public string GetConnectionString()
        {
            return "local DB";
        }
    }

    
   

   

    
    

   
     

    

   
}
