using System;

namespace HackerRannk
{
    class Program
    {
        static void Main(string[] args)
        {
       
            int n = Convert.ToInt32(Console.ReadLine());

            while (n >= 1)
            {
                int t = Convert.ToInt32(Console.ReadLine());
                string[] arr_temp = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
                int result = 1;

                for (int i = 0; i < t -1 ; i++)
                {
                    result = (result * arr[i]) % 1234567; //just add this modulo as the problem says
                }

                Console.WriteLine(result);
                n--;
            }

        }

       
    }
}
