using System;
using System.Threading;

namespace ThreadsPractice.Models
{
    public static class Vazifa2
    {
        static long[] qismanYigindilar = new long[4];

        public static void Run()
        {
            Thread t1 = new Thread(() => Hisobla(1, 250000, 0));
            Thread t2 = new Thread(() => Hisobla(250001, 500000, 1));
            Thread t3 = new Thread(() => Hisobla(500001, 750000, 2));
            Thread t4 = new Thread(() => Hisobla(750001, 1000000, 3));

            t1.Start(); t2.Start(); t3.Start(); t4.Start();
            t1.Join(); t2.Join(); t3.Join(); t4.Join();

            long jami = 0;
            foreach (long s in qismanYigindilar) jami += s;

            Console.WriteLine($" 1 dan 1,000,000 gacha yig'indi: {jami}");
        }

        static void Hisobla(int start, int end, int index)
        {
            long sum = 0;
            for (int i = start; i <= end; i++) sum += i;
            qismanYigindilar[index] = sum;
        }
    }
}