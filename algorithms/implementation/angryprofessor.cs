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
                string[] arr_temp1 = Console.ReadLine().Split(' ');
                int[] arr1 = Array.ConvertAll(arr_temp1, Int32.Parse);

                string[] arr_temp2 = Console.ReadLine().Split(' ');
                int[] arr2 = Array.ConvertAll(arr_temp2, Int32.Parse);

                int sum = 0;

                for (int i = 0; i < arr1[0]; i++)                
                    if (arr2[i] <= 0)
                        sum++;

                string ans = (arr1[1] > sum) ? "YES" : "NO";
                Console.WriteLine(ans);
                n--;
            }          
        }

       

    }
}
