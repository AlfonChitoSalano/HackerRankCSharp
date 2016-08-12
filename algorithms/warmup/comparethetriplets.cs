using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
    
         string[] tokens_a0 = Console.ReadLine().Split(' '); 
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int aScore = 0;
            int bScore = 0;

            for (int i = 0; i < tokens_a0.Length; ++i)
            {
                if (int.Parse(tokens_a0[i]) > int.Parse(tokens_b0[i]))
                    aScore++;
                else if (int.Parse(tokens_a0[i]) < int.Parse(tokens_b0[i]))
                    bScore++;
                             
            }

            Console.WriteLine(aScore + " " + bScore);
        
    }
}