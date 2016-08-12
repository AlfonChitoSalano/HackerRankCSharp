using System;

namespace HackerRannk
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://betterexplained.com/articles/easy-permutations-and-combinations/
            //I've use combination on this p! / (p!-m!) m!
            int n = Convert.ToInt32(Console.ReadLine());

            while (n >= 1)
            {
                int p = Convert.ToInt32(Console.ReadLine());
                int m = 2;

                int bL = p-m;
                int res = (p >= m) ? Factorial(p, bL) / m : 0;

                Console.WriteLine(res);
                n--;
            }           

        }

        static int Factorial(int i, int bL)
        {
            if (i <= 1 || i == bL)
                return 1;
            return i * Factorial(i - 1, bL);
        }


    }
}
