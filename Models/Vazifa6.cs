using System;
using System.Threading;

namespace ThreadsPractice.Models
{
    public static class Vazifa6
    {
        public static void Run()
        {
            Thread t1 = new Thread(() => ChopEt(1, 10));
            Thread t2 = new Thread(() => ChopEt(11, 20));
            Thread t3 = new Thread(() => ChopEt(21, 30));

            t1.Start(); t1.Join(); 
            t2.Start(); t2.Join(); 
            t3.Start(); t3.Join(); 
        }

        static void ChopEt(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine($"Oqim {Thread.CurrentThread.ManagedThreadId}: {i}");
            }
            Console.WriteLine("---------------------");
        }
    }
}