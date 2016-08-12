using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
       
                   int n = Convert.ToInt32(Console.ReadLine());

            if (n >= 1 && n <= 15)
            {
                int[] outputx = new int[n];
                int[] outputy = new int[n];

                int i = 0;
                do
                {
                    string[] arr_temp = Console.ReadLine().Split(' ');
                    int[] arr = Array.ConvertAll<string, int>(arr_temp, Int32.Parse);                   

                    if (arr.Length == 4)
                    {
                        int differencex = arr[2] - arr[0];
                        int differencey = arr[3] - arr[1];

                        outputx[i] = arr[2] + differencex;
                        outputy[i] = arr[3] + differencey;
                    }

                    ++i;
                }
                while (i <= n-1);

                if (outputx != null)
                { 
                    for(int y=0; y < outputx.Length; y++)
                    {
                        Console.Write(outputx[y]);
                        Console.Write(" ");
                        Console.Write(outputy[y]);
                        Console.WriteLine("");
                    }
                }

                Console.ReadKey();

            }
        
    }
}