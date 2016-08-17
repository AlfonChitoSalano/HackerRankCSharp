using System;

namespace HackerRankTests
{
    class Program
    {
        static void Main(string[] args)
        {
            int _ar_size = Convert.ToInt32(Console.ReadLine());
            int[] _ar = new int[_ar_size];
            String[] split_elements = Console.ReadLine().Split(' ');

            for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
            {
                _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
            }

            insertionSort(_ar);
        }

        static void insertionSort(int[] ar)
        {
            int s = ar.Length - 1;
            int os = s;
            int temp = 0;

            while (s >= 0)
            {
                bool hasHit = false;

                for (int j = s; j >= 0; j--)
                {
                    if (j > 0 && ar[j] < ar[j - 1])
                    {
                        temp = ar[j];
                        ar[j] = ar[j - 1];

                        for (int k = 0; k <= os; k++)
                        {
                            Console.Write(ar[k]);
                            Console.Write(" ");
                        }

                        ar[j - 1] = temp;
                        hasHit = true;
                        Console.WriteLine();
                    }
                    else if(hasHit)
                    {
                          for (int k = 0; k <= os; k++)
                            {
                                Console.Write(ar[k]);
                                Console.Write(" ");
                            }

                            hasHit = false;
                            Console.WriteLine();
                    }
                }
              
                s--;
            }

            Console.ReadLine();

        }


    }
}
