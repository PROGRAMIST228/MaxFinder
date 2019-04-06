using System;

namespace Ahmeds_Massive2
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 1;
            int[] a = new int[100];
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                a[i] = rand.Next(1, 1000);
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine("" + max);
            Console.ReadKey();
        }
    }
}
