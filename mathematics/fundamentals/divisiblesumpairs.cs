using System;

namespace HackerRannk
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arr_temp1 = Console.ReadLine().Split(' ');
            int[] arr1 = Array.ConvertAll(arr_temp1, Int32.Parse);

            string[] arr_temp2 = Console.ReadLine().Split(' ');
            int[] arr2 = Array.ConvertAll(arr_temp2, Int32.Parse);

            int res = 0;

            for (int i = 0; i < arr1[0]; i++)
            {
                for (int y = i + 1; y < arr1[0]; y++)
                {
                    if ((arr2[i] + arr2[y]) % arr1[1] == 0)                     
                        res++;
                                                        
                }
            }

            Console.WriteLine(res);       

          
        }

       

    }
}
