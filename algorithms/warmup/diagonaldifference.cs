using System;
using System.Linq;

namespace HackerRannk
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int sumFirst = 0;
            int sumSecond = 0;

            while (n >= 1)
            {
                string[] arrTemp = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(arrTemp, Int32.Parse);

                sumSecond += arr[n-1];
                sumFirst += arr[count];

                count++;
                n--;
            }

            Console.WriteLine(Math.Abs(sumFirst - sumSecond));
        }

       
    }
}
