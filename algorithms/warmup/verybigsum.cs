using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
         int n = Convert.ToInt32(Console.ReadLine());
            long sum = 0;

            string[] arr_temp = Console.ReadLine().Split(' ');
            long[] arr = Array.ConvertAll(arr_temp, Int64.Parse);

            for (int c = 0; c < n; c++)
            {
                sum += arr[c];
            }

            Console.WriteLine(sum);
    }
}
