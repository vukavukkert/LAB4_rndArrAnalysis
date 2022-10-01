using System;

namespace LAB4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] M = new int[100];
            Random rand = new Random(DateTime.Now.Millisecond);
            Random n = new Random(2);
            int x;
            Console.WriteLine("100 рандомных чисел от -1000 до 1000");
            for (x = 0;x < M.Length; x++)
            {
                int r = rand.Next(2);
                M[x] = rand.Next(1000);
                M[x] = r == 0 ? M[x] : -M[x];
                Console.Write(M[x] + ", "); 
            }

            Console.WriteLine("\nРандомные четные числа");
            for (x = 0; x < M.Length; x++)
            {
                if(M[x] % 2 == 0)
                {
                    Console.Write(M[x] + ", ");
                }
            }
            Console.WriteLine("\nРандомные числа кратные трем");
            for (x = 0; x < M.Length; x++)
            {
                if (M[x] % 3 == 0)
                {
                   Console.Write(M[x] + ", ");
                }

            }
            Console.WriteLine("\nСумма всех отрицательных чисел");
            int t = 0;
            for (x = 0; x < M.Length; x++)
            {
                if (M[x] < 0)
                {
                    t = t + M[x];
                }
            }
            Console.WriteLine(t);
        }
    }
}
