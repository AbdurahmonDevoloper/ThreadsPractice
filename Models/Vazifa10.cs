using System;
using System.Threading;

namespace ThreadsPractice.Models
{
    public static class Vazifa10
    {
        static int chiptalar = 100;
        static readonly object kassaQulf = new object();

        public static void Run()
        {
            chiptalar = 100;
            Thread[] xaridorlar = new Thread[20];
            Random r = new Random();

            for (int i = 0; i < 20; i++)
            {
                string ism = $"Xaridor-{i + 1}";
                int dona = r.Next(1, 10);
                xaridorlar[i] = new Thread(() => ChiptaSotibOl(ism, dona));
                xaridorlar[i].Start();
            }
            foreach (var c in xaridorlar) c.Join();
        }

        static void ChiptaSotibOl(string kim, int qancha)
        {
            lock (kassaQulf)
            {
                if (chiptalar >= qancha)
                {
                    chiptalar -= qancha;
                    Console.WriteLine($" {kim} {qancha} ta chipta oldi. Qoldi: {chiptalar}");
                }
                else
                {
                    Console.WriteLine($" {kim} {qancha} ta ololmadiki! Chipta yetarli emas. Bor: {chiptalar}");
                }
            }
        }
    }
}