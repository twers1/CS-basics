using System;

namespace properties
{
    // Свойства(Properties) get и set
    class Program 
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.SetX(10);
            int x  = point.GetX();

            Point point2 = new Point();
            point2.Y = 10;
            int y = point.Y;

            Point point3 = new Point();
            point.Z = 1;
            int z = point.Z;
            
        }
    }

   
    class Point
    {
        private int x;

        public void SetX(int x)
        { 
            if(x < 1)
            {
                this.x = 1;
                return;
            }
            if (x > 5)
            {
                this.x = 5;
                return;
            }
            this.x = x;
        } // это метод, с помощью которого мы установливаем/присвоиваем какое-то значение
        public int GetX() // это метод, с помощью которого мы можем получить доступ к private переменной  
        {
            return x;
        }

        // propfull + 2tab
        private int y;

        public int Y
        {
            // get и set можно выдавать свой модицикатор(public, private)
            // get и set это аксессоры в свойстве public int Y
            get 
            { 
                return y;
            }
            set
            { 
                if(value< 1)
                {
                    y = 1;
                    return;
                }
                if(value > 5) { 
                    y = 5;
                    return;
                }


                // ключевое слово value - это то же самое, что входящий параметр в методе SetX
                y = value; 
            }
        }

        // Автоматическое свойство prop + 2tab
        public int Z { get; set; }
        // под капотом там то же самое, что и в propfull 


    }

    

   
}
