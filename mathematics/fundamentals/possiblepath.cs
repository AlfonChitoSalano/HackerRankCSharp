using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            int ann = GCD(2, 3);

            while (t >= 1)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

                if (GCD(Math.Abs(arr[0]), Math.Abs(arr[1])) == GCD(Math.Abs(arr[2]), Math.Abs(arr[3])))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");

                t--;
            }
            Console.ReadLine();
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