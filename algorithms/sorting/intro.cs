using System;

namespace HackerRannk
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine());

            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            for (int i = 0; i < q; i++)
            {
                if (arr[i] == n)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

        }

       

    }
}
