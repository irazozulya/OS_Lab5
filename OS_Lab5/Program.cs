using System;
using System.Diagnostics;

namespace OS_Lab5
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Stopwatch clock = new Stopwatch();
            clock.Start();
            int[,] MB = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    MB[i, j]++;
                }
            }
            clock.Stop();

            Console.WriteLine($"Time spent for executing: {clock.Elapsed}");
        }
    }
}
