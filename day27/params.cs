using System;

namespace properties
{
    // Params
    class Program 
    {
        static void Main(string[] args)
        {
            int result = Sum();
            Console.WriteLine(result);
        }

        static int Sum(params int[] parameters)
        {
            int result = 0;
            for (int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i];
            }

            return result;
        }
    }

   
     

    

   
}
