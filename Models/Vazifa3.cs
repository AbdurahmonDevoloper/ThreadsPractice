using System;
using System.Threading;

namespace ThreadsPractice.Models
{
    public static class Vazifa3
    {
        private static int balans = 1000;
        private static readonly object qulf = new object();

        public static void Run()
        {
            balans = 1000;
            Thread[] odamlar = new Thread[5];
            for (int i = 0; i < 5; i++)
            {
                odamlar[i] = new Thread(PulYech);
                odamlar[i].Name = $"Mijoz-{i + 1}";
                odamlar[i].Start();
            }
            foreach (var t in odamlar) t.Join();
        }

        static void PulYech()
        {
            for (int i = 0; i < 2; i++)
            {
                lock (qulf)
                {
                    if (balans >= 100)
                    {
                        Thread.Sleep(10);
                        balans -= 100;
                        Console.WriteLine($"[OK] {Thread.CurrentThread.Name} 100 yechdi. Qoldiq: {balans}");
                    }
                    else
                    {
                        Console.WriteLine($"[XATO] {Thread.CurrentThread.Name}: Pul yetarli emas!");
                    }
                }
                Thread.Sleep(10);
            }
        }
    }
}