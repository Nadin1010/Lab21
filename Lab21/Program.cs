using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab21
{
    class Program
    {
        public static int n = 2;
        public static int m = 3;
        public static int[,] garden = new int[,] { { 1, 2, 0, }, { 3, 4, 5 } };
        static void Main(string[] args)
        {
            ThreadStart threadStart1 = new ThreadStart(Gardner1);
            Thread thread1 = new Thread(threadStart1);
            thread1.Start();

            Gardner2();

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)

                    Console.Write($"{garden[i, j]} ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }



        static void Gardner1()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (garden[i, j] >= 0)
                    {
                        int delay = garden[i, j];
                        garden[i, j] = -1;
                        Thread.Sleep(delay);
                    }
                }
            }

        }
        static void Gardner2()
        {
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = m - 1; j >= 0; j--)
                {
                    if (garden[i, j] >= 0)
                    {
                        int delay = garden[i, j];
                        garden[i, j] = -2;
                        Thread.Sleep(delay);
                    }
                }
            }
        }
    }
}
