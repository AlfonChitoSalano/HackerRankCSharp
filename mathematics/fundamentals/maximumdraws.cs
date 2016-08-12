using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
         int t = Convert.ToInt32(Console.ReadLine());

            while (t >= 1)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(input + 1);
                t--;
            }
    }
}