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
                string[] arr_temp = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

                int gcd = GCD(arr[0], arr[1]);
                int res = Math.Abs((arr[0] / gcd) * (arr[1] / gcd));
                Console.WriteLine(res);               
                n--;
            }

        }

        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int tmp = b;
                b = a % b;
                a = tmp;
            }

            return a;
        }


    }
}
