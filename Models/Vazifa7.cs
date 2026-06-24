using System;
using System.Collections.Generic;
using System.Threading;

namespace ThreadsPractice.Models
{
    public static class Vazifa7
    {
        static List<int>[] topilganlar = new List<int>[4];

        public static void Run()
        {
            for (int i = 0; i < 4; i++) topilganlar[i] = new List<int>();

            Thread t1 = new Thread(() => Qidir(1, 25000, 0));
            Thread t2 = new Thread(() => Qidir(25001, 50000, 1));
            Thread t3 = new Thread(() => Qidir(50001, 75000, 2));
            Thread t4 = new Thread(() => Qidir(75001, 100000, 3));

            t1.Start(); t2.Start(); t3.Start(); t4.Start();
            t1.Join(); t2.Join(); t3.Join(); t4.Join();

            List<int> jamiTubSonlar = new List<int>();
            foreach (var list in topilganlar) jamiTubSonlar.AddRange(list);

            Console.WriteLine($" Jami topilgan tub sonlar soni: {jamiTubSonlar.Count} ta.");
        }

        static void Qidir(int start, int end, int index)
        {
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i)) topilganlar[index].Add(i);
            }
        }

        static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i * i <= n; i++) if (n % i == 0) return false;
            return true;
        }
    }
}