using System;
using System.Threading;

namespace ThreadsPractice.Models
{
    public static class Vazifa1
    {
        public static void Run()
        {
            Thread tA = new Thread(PrintNumbers);
            Thread tB = new Thread(PrintNumbers);
            Thread tC = new Thread(PrintNumbers);

            tA.Name = "Oqim A"; tB.Name = "Oqim B"; tC.Name = "Oqim C";

            tA.Start(); tB.Start(); tC.Start();
            tA.Join(); tB.Join(); tC.Join();
        }

        static void PrintNumbers()
        {
            Random random = new Random();
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name}: {i}");
                Thread.Sleep(random.Next(5, 20));
            }
        }
    }
}